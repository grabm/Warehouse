using System.Collections.Generic;

namespace Warehouse.Api.Domain
{
    public class DocumentKWZ : Document
    {
        public long DocumentWZId { get; private set; }
        public DocumentKWZ(string documentNumber, long documentWZId, IEnumerable<DocumentItem> items) : base(documentNumber, items)
        {
            DocumentWZId = documentWZId;
        }

        public override void Approve()
        {
            base.Approve();

            // TODO: add event approved document KWZ
        }
    }
}
