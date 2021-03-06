﻿// Copyright 2015 Serilog Contributors
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#if APPCONFIG

namespace Serilog.Configuration
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Collection of configuration items for use in generating DataColumn[]
    /// </summary>
    public class ColumnCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// Create new element
        /// </summary>
        /// <returns>new ColumnConfig instance</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new ColumnConfig();
        }

        /// <summary>
        /// Fetch Key for the Element
        /// </summary>
        /// <param name="element"></param>
        /// <returns>ColumnName</returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ColumnConfig)element).ColumnName;
        }
    }
}

#endif
