using System.Text;

namespace SqlLoaderEditor.Core
{
    /// <summary>
    /// TERMINATED BY ','                      a data string,
    /// TERMINATED BY ',' ENCLOSED BY '"'      "a data string", 
    /// </summary>
    public class TerminationAndEnclosureSpecification
    {
        public string TerminatedBy { get; set; }
        public string EnclosedBy { get; set; }

        public override string ToString()
        {
            var ret = new StringBuilder();

            if (string.IsNullOrWhiteSpace(TerminatedBy) == false)
            {
                ret.Append(string.Format("TERMINATED BY '{0}'", TerminatedBy));
            }
            if (string.IsNullOrWhiteSpace(EnclosedBy) == false)
            {
                ret.Append(string.Format(" OPTIONALLY ENCLOSED BY '{0}'", EnclosedBy));
            }
            ret.AppendLine();

            return ret.ToString();
        }
    }
}
