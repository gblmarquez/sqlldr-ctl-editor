
namespace SqlLoaderEditor.Core
{
    public class FieldSpecification
    {
        public string Name { get; set; }
        public FixedSizeSpecification Position { get; set; }
        public DataTypeSpecification DataType { get; set; }
        public string Operators { get; set; }
        public bool IsFiller { get; set; }

        public override string ToString()
        {
            var ret = this.Name;

            if (this.IsFiller)
            {
                ret += "\tFILLER";
            }
            if (this.Position != null)
            {
                ret += "\t" + this.Position.ToString();
            }
            if (this.DataType != null)
            {
                ret += "\t" + this.DataType.ToString();
            }
            if (string.IsNullOrWhiteSpace(this.Operators) == false)
            {
                ret += "\t" + "\"" + Operators.Replace(":@", ":" + this.Name) + "\"";
            }

            return ret;
        }
    }

    public class FixedSizeSpecification
    {
        public int Start { get; set; }
        public int? End { get; set; }

        public override string ToString()
        {
            var ret = string.Format("POSITION({0}", this.Start);

            if (this.End.HasValue && this.End.Value > 0)
            {
                ret += ":" + this.End.Value.ToString();
            }

            ret += ")";

            return ret;
        }
    }
}
