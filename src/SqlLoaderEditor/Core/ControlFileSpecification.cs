using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SqlLoaderEditor.Core
{
    /// SQL*Loader Syntax Diagrams: http://docs.oracle.com/cd/B10500_01/server.920/a96652/apa.htm

    /// <summary>
    /// This is the mainly specification, it's the header of the file.
    /// </summary>
    public class ControlFileSpecification
    {
        public ControlFileSpecification()
        {
            this.DataFiles = new Collection<DataFileSpecification>();
        }

        public LoadMethods LoadMethod { get; set; }
        public string TableName { get; set; }
        public string PartitionName { get; set; }
        public int Skip { get; set; }
        public bool ContinueLoad { get; set; }
        public bool IsDelimited { get; set; }
        /// <summary>
        /// The TRAILING NULLCOLS clause tells SQL*Loader to treat any relatively positioned columns that are not present in the record as null columns.
        /// </summary>
        public bool TrailingNullColumns { get; set; }
        public string WhenClause { get; set; }

        public ICollection<DataFileSpecification> DataFiles { get; set; }

        public override string ToString()
        {
            var ret = new StringBuilder();

            if (this.ContinueLoad)
            {
                ret.AppendLine("CONTINUE_LOAD");
            }
            else
            {
                ret.AppendLine("LOAD DATA");
            }

            if (this.Skip > 0)
            {
                ret.AppendLine(string.Format("SKIP {0}", this.Skip));
            }

            // data files
            foreach (var item in this.DataFiles)
            {
                if (string.IsNullOrEmpty(item.InFile) == false)
                    ret.AppendFormat("INFILE '{0}'", item.InFile);
                if (string.IsNullOrEmpty(item.BadFile) == false)
                    ret.AppendFormat(" BADFILE '{0}'", item.BadFile);
                if (string.IsNullOrEmpty(item.DiscardFile) == false)
                    ret.AppendFormat(" DISCARDFILE '{0}'", item.DiscardFile);

                // if any clause was added, then we append a new line.
                if (string.IsNullOrEmpty(item.InFile) == false
                    && string.IsNullOrEmpty(item.BadFile) == false
                    && string.IsNullOrEmpty(item.DiscardFile) == false)
                    ret.AppendLine();
            }

            // load method
            ret.AppendLine(this.LoadMethod.ToString().ToUpperInvariant());

            // into table statement
            ret.Append(string.Format("INTO TABLE {0}", this.TableName));
            if (string.IsNullOrWhiteSpace(this.PartitionName) == false)
            {
                ret.Append(string.Format(" PARTITION {0}", this.PartitionName));
            }

            // trailing null columns
            if (this.TrailingNullColumns)
            {
                ret.AppendLine("TRAILING NULLCOLS");
            }

            return ret.ToString();
        }
    }
}
