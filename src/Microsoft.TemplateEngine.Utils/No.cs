﻿using System.Collections.Generic;

namespace Microsoft.TemplateEngine.Utils
{
    public static class No<T>
    {
        public static class List
        {
            // ReSharper disable once StaticMemberInGenericType
            public static readonly IReadOnlyList<T> Value = new List<T>();
        }
    }
}
