using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class HeaderDocumentComponent: IDocumentComponent
    {
        private string Name = "Header";

        public List<IDocumentComponent> DocumentHeaders { get; private set; }

        public HeaderDocumentComponent()
        {
            DocumentHeaders = new List<IDocumentComponent>();
        }

        public string GatherData()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"<{Name}>");
            stringBuilder.AppendLine($"  <MessageTime>{DateTime.Now.ToString("hh\\:mm\\:ss")}</MessageTime>");
            foreach (var documentComponent in DocumentHeaders)
            {
                documentComponent.GatherData();
                stringBuilder.AppendLine(documentComponent.GatherData());
            }
            stringBuilder.AppendLine($"</{Name}>");
            return stringBuilder.ToString();
        }

        public void AddComponent(IDocumentComponent documentComponent)
        {
            DocumentHeaders.Add(documentComponent);
        }
    }
}
