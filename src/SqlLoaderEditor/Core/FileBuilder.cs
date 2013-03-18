
using SqlLoaderEditor.Models;
using System.Collections.Generic;
using System.Text;
namespace SqlLoaderEditor.Core
{
    public class FileBuilder
    {
        private ControlFileSpecification ControlFileSpec;
        private TerminationAndEnclosureSpecification TerminationAndEnclosureSpec;
        private List<FieldSpecification> Fields;

        public FileBuilder()
        {
            this.Fields = new List<FieldSpecification>();
        }

        public FileBuilder SetControlFile(ControlFileSpecification spec)
        {
            this.ControlFileSpec = spec;
            return this;
        }

        public FileBuilder SetTerminationAndEnclosure(TerminationAndEnclosureSpecification spec)
        {
            this.TerminationAndEnclosureSpec = spec;
            return this;
        }

        public FileBuilder AddField(FieldModel model)
        {
            this.Fields.Add(CreateFrom(model));
            return this;
        }

        public FileBuilder AddField(FixedSizeFieldModel model)
        {
            this.Fields.Add(CreateFrom(model));
            return this;
        }

        public static FieldSpecification CreateFrom(FixedSizeFieldModel model)
        {
            var ret = CreateFrom(model as FieldModel);
            ret.Position = new FixedSizeSpecification()
            {
                Start = model.PositionStart,
                End = model.PositionEnd
            };
            return ret;
        }

        public static FieldSpecification CreateFrom(FieldModel model)
        {
            var ret = new FieldSpecification();
            ret.Name = model.Name;
            ret.Operators = model.Operators;
            ret.IsFiller = model.IsFiller;
            ret.DataType = new DataTypeSpecification()
            {
                Type = model.DataType,
                IsExternal = model.DataTypeIsExternal
            };
            return ret;
        }

        public string Build()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.ControlFileSpec.ToString());
            sb.AppendLine(this.TerminationAndEnclosureSpec.ToString());

            sb.AppendLine("(");

            var items = this.Fields;
            foreach (var item in items)
            {
                sb.AppendFormat("\t{0},\r\n", item.ToString());
            }
            // remove finishing ',' character
            sb.Remove(sb.Length - 3, 1);

            sb.AppendLine(")");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Build();
        }
    }
}
