﻿#region Copyright 2013-2021 C. Augusto Proiete & Contributors
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
//
#endregion

using System;

namespace ExcelDna.Integration.CustomUI.Abstractions
{
    public class CustomTaskPaneFactoryWrapper : CustomTaskPaneFactoryBase
    {
        public static readonly ICustomTaskPaneFactory Instance = new CustomTaskPaneFactoryWrapper();

        public override CustomTaskPane CreateCustomTaskPane(Type userControlType, string title)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(userControlType, title);
        }

        public override CustomTaskPane CreateCustomTaskPane(Type userControlType, string title, object parent)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(userControlType, title, parent);
        }

        public override CustomTaskPane CreateCustomTaskPane(object userControl, string title)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(userControl, title);
        }

        public override CustomTaskPane CreateCustomTaskPane(object userControl, string title, object parent)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(userControl, title, parent);
        }

        public override CustomTaskPane CreateCustomTaskPane(string controlProgId, string title)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(controlProgId, title);
        }

        public override CustomTaskPane CreateCustomTaskPane(string controlProgId, string title, object parent)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(controlProgId, title, parent);
        }
    }
}
