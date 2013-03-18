
namespace SqlLoaderEditor.Core
{
    public enum DataTypes
    {
        Constant,
        Char,
        Date,
        Decimal,
        Double,
        Integer,
        Float,
        SmallInteger,
        Zoned
    }

    /// <summary>
    /// Data type specification, this class is to validate data types for FieldSpecifications.
    /// </summary>
    public class DataTypeSpecification
    {
        public DataTypes Type { get; set; }

        /// <summary>
        /// These datatypes are the human-readable, character form of numeric data.
        /// </summary>
        public bool IsExternal { get; set; }

        public override string ToString()
        {
            var ret = string.Empty;

            switch (this.Type)
            {
                case DataTypes.Integer:
                    ret = "INTEGER";
                    break;
                case DataTypes.SmallInteger:
                    ret = "SMALLINT";
                    break;
                case DataTypes.Float:
                    ret = "FLOAT";
                    break;
                case DataTypes.Double:
                    ret = "DOUBLE";
                    break;
                case DataTypes.Constant:
                    ret = "CONSTANT";
                    break;
                case DataTypes.Zoned:
                    ret = "ZONED";
                    break;
                case DataTypes.Decimal:
                    ret = "DECIMAL";
                    break;
                case DataTypes.Char:
                    ret = "CHAR";
                    break;
                default:
                    break;
            }

            if (this.IsExternal)
            {
                ret += " EXTERNAL";
            }

            return ret;
        }
    }
}
