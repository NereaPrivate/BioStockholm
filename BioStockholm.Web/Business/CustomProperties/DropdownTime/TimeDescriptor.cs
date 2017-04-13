using System;
using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace BioStockholm.Web.Business.CustomProperties.DropdownTime
{
    [EditorDescriptorRegistration(TargetType = typeof(string), UIHint = "Tider")]
    public class TimeDescriptor : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            SelectionFactoryType = typeof(TimeFactory);
            ClientEditingClass = "epi.cms.contentediting.editors.SelectionEditor";
            base.ModifyMetadata(metadata, attributes);
        }
    }
}