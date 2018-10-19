﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal static class SymbolDisplayPartExtensions
    {
        public static bool IsPunctuation(this SymbolDisplayPart part)
        {
            return part.Kind == SymbolDisplayPartKind.Punctuation;
        }

        public static bool IsSpace(this SymbolDisplayPart part)
        {
            return part.Kind == SymbolDisplayPartKind.Space;
        }

        public static bool IsKeyword(this SymbolDisplayPart part, string text)
        {
            return part.Kind == SymbolDisplayPartKind.Keyword
                && part.ToString() == text;
        }

        internal static bool IsTypeNameOrMemberName(this SymbolDisplayPart part)
        {
            switch (part.Kind)
            {
                case SymbolDisplayPartKind.ClassName:
                case SymbolDisplayPartKind.DelegateName:
                case SymbolDisplayPartKind.EnumName:
                case SymbolDisplayPartKind.EventName:
                case SymbolDisplayPartKind.FieldName:
                case SymbolDisplayPartKind.InterfaceName:
                case SymbolDisplayPartKind.MethodName:
                case SymbolDisplayPartKind.PropertyName:
                case SymbolDisplayPartKind.StructName:
                    return true;
                default:
                    return false;
            }
        }

        internal static bool IsTypeName(this SymbolDisplayPart part)
        {
            switch (part.Kind)
            {
                case SymbolDisplayPartKind.ClassName:
                case SymbolDisplayPartKind.DelegateName:
                case SymbolDisplayPartKind.EnumName:
                case SymbolDisplayPartKind.InterfaceName:
                case SymbolDisplayPartKind.PropertyName:
                case SymbolDisplayPartKind.StructName:
                    return true;
                default:
                    return false;
            }
        }

        internal static bool IsName(this SymbolDisplayPart part)
        {
            switch (part.Kind)
            {
                case SymbolDisplayPartKind.AliasName:
                case SymbolDisplayPartKind.AssemblyName:
                case SymbolDisplayPartKind.ClassName:
                case SymbolDisplayPartKind.DelegateName:
                case SymbolDisplayPartKind.EnumName:
                case SymbolDisplayPartKind.ErrorTypeName:
                case SymbolDisplayPartKind.EventName:
                case SymbolDisplayPartKind.FieldName:
                case SymbolDisplayPartKind.InterfaceName:
                case SymbolDisplayPartKind.LabelName:
                case SymbolDisplayPartKind.LocalName:
                case SymbolDisplayPartKind.MethodName:
                case SymbolDisplayPartKind.ModuleName:
                case SymbolDisplayPartKind.NamespaceName:
                case SymbolDisplayPartKind.ParameterName:
                case SymbolDisplayPartKind.PropertyName:
                case SymbolDisplayPartKind.StructName:
                case SymbolDisplayPartKind.TypeParameterName:
                case SymbolDisplayPartKind.RangeVariableName:
                    return true;
                default:
                    return false;
            }
        }

        public static SymbolDisplayPart WithText(this SymbolDisplayPart part, string text)
        {
            return new SymbolDisplayPart(part.Kind, part.Symbol, text);
        }
    }
}