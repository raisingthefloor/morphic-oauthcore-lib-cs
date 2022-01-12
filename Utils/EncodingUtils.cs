// Copyright 2021-2022 Raising the Floor - US, Inc.
//
// Licensed under the New BSD license. You may not use this file except in
// compliance with this License.
//
// You may obtain a copy of the License at
// https://github.com/raisingthefloor/morphic-oauthcore-lib-cs/blob/main/LICENSE
//
// The R&D leading to these results received funding from the:
// * Rehabilitation Services Administration, US Dept. of Education under
//   grant H421A150006 (APCP)
// * National Institute on Disability, Independent Living, and
//   Rehabilitation Research (NIDILRR)
// * Administration for Independent Living & Dept. of Education under grants
//   H133E080022 (RERC-IT) and H133E130028/90RE5003-01-00 (UIITA-RERC)
// * European Union's Seventh Framework Programme (FP7/2007-2013) grant
//   agreement nos. 289016 (Cloud4all) and 610510 (Prosperity4All)
// * William and Flora Hewlett Foundation
// * Ontario Ministry of Research and Innovation
// * Canadian Foundation for Innovation
// * Adobe Foundation
// * Consumer Electronics Association Foundation

using System;
using System.Net;
using System.Text;

namespace Morphic.OAuth.Utils
{
    public struct EncodingUtils
    {
        public const string CONTENT_TYPE_APPLICATION_JSON = "application/json";

        // NOTE: this function verifies that the content is "application/json" but does not restrict the character set
        public static bool VerifyContentTypeIsApplicationJson(string contentType)
        {
            if ((contentType == EncodingUtils.CONTENT_TYPE_APPLICATION_JSON) || (contentType.StartsWith(EncodingUtils.CONTENT_TYPE_APPLICATION_JSON + ";")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
