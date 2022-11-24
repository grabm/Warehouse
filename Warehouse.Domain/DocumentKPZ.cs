﻿using System.Collections.Generic;

namespace Warehouse.Api.Domain
{
    public class DocumentKPZ : Document
    {
        public long DocumentPZId { get; private set; }
        public DocumentKPZ(string documentNumber, long documentPZId, IEnumerable<DocumentItem> items) : base(documentNumber, items)
        {
            DocumentPZId = documentPZId;
        }

        public override void Approve()
        {
            base.Approve();

            // TODO: add event approved document KPZ
        }

        public override bool ValidateUpdate(IEnumerable<DocumentItem> items) => true;
    }
}
