﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace ExcelDna.Integration.Abstractions
{
    public interface IExcelIntegration
    {
        IEnumerable<Assembly> GetExportedAssemblies();

        object GetRegistrationInfo(string xllPath, double registrationUpdateVersion);

        void RegisterMethods(List<MethodInfo> methods);
        void RegisterDelegates(List<Delegate> delegates, List<object> methodAttributes, List<List<object>> argumentAttributes);

        void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler);
        UnhandledExceptionHandler GetRegisterUnhandledExceptionHandler();
    }
}
