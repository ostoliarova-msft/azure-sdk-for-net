// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Parameters for generating an ARM template for deploying artifacts. </summary>
    public partial class DevTestLabArtifactGenerateArmTemplateContent
    {
        /// <summary> Initializes a new instance of DevTestLabArtifactGenerateArmTemplateContent. </summary>
        public DevTestLabArtifactGenerateArmTemplateContent()
        {
            Parameters = new ChangeTrackingList<DevTestLabParameter>();
        }

        /// <summary> The resource name of the virtual machine. </summary>
        public string VmName { get; set; }
        /// <summary> The parameters of the ARM template. </summary>
        public IList<DevTestLabParameter> Parameters { get; }
        /// <summary> The location of the virtual machine. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Options for uploading the files for the artifact. UploadFilesAndGenerateSasTokens is the default value. </summary>
        public DevTestLabFileUploadOption? FileUploadOptions { get; set; }
    }
}
