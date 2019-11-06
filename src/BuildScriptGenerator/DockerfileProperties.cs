﻿// --------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
// --------------------------------------------------------------------------------------------

namespace Microsoft.Oryx.BuildScriptGenerator
{
    public class DockerfileProperties
    {
        /// <summary>
        /// Gets or sets the name of the platform whose image we're pulling from.
        /// </summary>
        public string RuntimeImageName { get; set; }

        /// <summary>
        /// Gets or sets the version of the platform to use as the tag we're pulling from.
        /// </summary>
        public string RuntimeImageTag { get; set; }

        /// <summary>
        /// Gets or sets the tag of the build image we're pulling from (either 'latest' or 'slim').
        /// </summary>
        public string BuildImageTag { get; set; }
    }
}
