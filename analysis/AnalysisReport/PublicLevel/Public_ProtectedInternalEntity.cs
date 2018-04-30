﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnalysisReport
{
    public class Public_InternalProtectedEntity
    {
        public Public_InternalProtectedEntity()
        {
            Field = "1";
            Property = "1";
            StaticField = "1";
            StaticProperty = "1";
            ReadOnlyField = "1";
        }

        public string GetFiled()
        {
            return Field;
        }
        protected internal string Field;
        protected internal string Property { get; set; }

        protected internal static string StaticField;
        protected internal static string StaticProperty { get; set; }

        protected internal const string ConstField = "1";

        protected internal readonly string ReadOnlyField;
    }
}
