using System.Collections.Generic;
using System.Linq;

namespace Warehouse.Api.Domain
{
    public class DocumentWZ : Document
    {
        public DocumentWZ(string documentNumber, IEnumerable<DocumentItem> items) : base(documentNumber, items)
        {
            bool quantityMoreThanZero = items.Any(x => x.Quantity > 0);

            if (quantityMoreThanZero)
                throw new System.Exception("Dokument WZ akceptuje tylko ujemny stan produktu");
        }

        public override void Approve()
        {
            base.Approve();

            // TODO: add event approved document WZ
        }
    }
}
