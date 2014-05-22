// 
//  Copyright (c) Microsoft Corporation. All rights reserved. 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  

namespace Microsoft.OneGet {
    using System;
    using System.Collections.Generic;
    using Core.Providers.Package;
    using Callback = System.Func<string, System.Collections.Generic.IEnumerable<object>, object>;

    /// <summary>
    /// The current Package Management Service Interface 
    /// 
    /// Binding directly to this is discouraged, as the interface is expected to be incrementally
    /// expanded over time.
    /// 
    /// In order to access the interface, the Host (client) is encouraged to copy this interface
    /// into their own project and use the <code>PackageManagementService.GetInstance<![CDATA[<>]]></code>
    /// method to dynamically generate a matching implementation at load time.
    /// </summary>
    public interface IPackageManagementService {
        IEnumerable<PackageProvider> SelectProviders(string provider);

        IEnumerable<PackageProvider> SelectProviders(string providerName, IEnumerable<string> sourceNames);

        bool Initialize(Callback c, bool userInteractionPermitted);
    }
}