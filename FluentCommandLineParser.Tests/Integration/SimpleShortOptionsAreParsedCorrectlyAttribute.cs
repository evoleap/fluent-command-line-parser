﻿#region License
// SimpleShortOptionsAreParsedCorrectlyAttribute.cs
// Copyright (c) 2014, Simon Williams
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provide
// d that the following conditions are met:
// 
// Redistributions of source code must retain the above copyright notice, this list of conditions and the
// following disclaimer.
// 
// Redistributions in binary form must reproduce the above copyright notice, this list of conditions and
// the following disclaimer in the documentation and/or other materials provided with the distribution.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED 
// WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED
// TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE.
#endregion

using Fclp.Tests.FluentCommandLineParser;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit;
using Xunit.Extensions;
using Xunit.Sdk;

namespace Fclp.Tests.Integration
{
    public class SimpleShortOptionsAreParsedCorrectlyAttribute : DataAttribute
    {
        private InlineDataAttribute _internalData;

        public SimpleShortOptionsAreParsedCorrectlyAttribute(string arguments) : this(arguments, null) { }

        public SimpleShortOptionsAreParsedCorrectlyAttribute(
            string arguments,
            bool? expectedBoolean = null,
            string expectedString = null,
            int? expectedInt32 = null,
            long? expectedInt64 = null,
            double? expectedDouble = null,
            TestEnum? expectedEnum = null)
        {
            _internalData = new InlineDataAttribute(arguments, expectedBoolean, expectedString, expectedInt32, expectedInt64, expectedDouble, expectedEnum);
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod) => _internalData.GetData(testMethod);
    }
}