using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class DocumentComponent: IDocumentComponent
    {
        public string Name { get; private set; }

        public List<IDocumentComponent> DocumentComponents { get; private set; }

        public DocumentComponent(string name)
        {
            Name = name;
            DocumentComponents = new List<IDocumentComponent>();
        }

        public string GatherData()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"<{Name}>");
            foreach(var documentComponent in DocumentComponents)
            {
                documentComponent.GatherData();
                stringBuilder.AppendLine(documentComponent.GatherData());
            }
            stringBuilder.AppendLine($"</{Name}>");
            return stringBuilder.ToString();
        }

        public void AddComponent(IDocumentComponent documentComponent)
        {
            DocumentComponents.Add(documentComponent);
        }
    }
}
