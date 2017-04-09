﻿using EPiServer.Core;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using System;
using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing;

namespace BioStockholm.Web.Business.EditorDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(CategoryList))]
    public class HideCategoryEditorDescriptor : EditorDescriptor
    {
        public override void ModifyMetadata(
           ExtendedMetadata metadata,
           IEnumerable<Attribute> attributes)
        {
            base.ModifyMetadata(metadata, attributes);
            if (metadata.PropertyName == "icategorizable_category")
            {
                metadata.ShowForEdit = false;
            }
        }
    }
}