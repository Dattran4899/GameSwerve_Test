// Copyright 2009-2021 Josh Close
// This file is a part of CsvHelper and is dual licensed under MS-PL and Apache 2.0.
// See LICENSE.txt for details or visit http://www.opensource.org/licenses/ms-pl.html for MS-PL and http://opensource.org/licenses/Apache-2.0 for Apache 2.0.
// https://github.com/JoshClose/CsvHelper

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;
using System.Reflection;

namespace CsvHelper.TypeConversion
{
    using System.Globalization;
    using MechSharingCode.Blueprints.BlueprintReader.TypeConversionExtend;

    /// <summary>
    /// Caches <see cref="ITypeConverter"/>s for a given type.
    /// </summary>
    public class TypeConverterCache
    {
        private readonly Dictionary<Type, ITypeConverter> typeConverters = new Dictionary<Type, ITypeConverter>();

        /// <summary>
        /// Initializes the <see cref="TypeConverterCache" /> class.
        /// </summary>
        public TypeConverterCache()
        {
            // Set default culture is InvariantCulture to avoid issues relate to the region format. Example in Russian, decimal symbol is ',' but in current culture it's '.'
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            
            CreateDefaultConverters();
        }

        /// <summary>
        /// Adds the <see cref="ITypeConverter"/> for the given <see cref="System.Type"/>.
        /// </summary>
        /// <param name="type">The type the converter converts.</param>
        /// <param name="typeConverter">The type converter that converts the type.</param>
        public void AddConverter(Type type, ITypeConverter typeConverter)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            if (typeConverter == null)
            {
                throw new ArgumentNullException(nameof(typeConverter));
            }

            typeConverters[type] = typeConverter;
        }

        /// <summary>
        /// Adds the <see cref="ITypeConverter"/> for the given <see cref="System.Type"/>.
        /// </summary>
        /// <typeparam name="T">The type the converter converts.</typeparam>
        /// <param name="typeConverter">The type converter that converts the type.</param>
        public void AddConverter<T>(ITypeConverter typeConverter)
        {
            if (typeConverter == null)
            {
                throw new ArgumentNullException(nameof(typeConverter));
            }

            typeConverters[typeof(T)] = typeConverter;
        }

        /// <summary>
        /// Adds the given <see cref="ITypeConverter"/> to all registered types.
        /// </summary>
        /// <param name="typeConverter">The type converter.</param>
        public void AddConverter(ITypeConverter typeConverter)
        {
            foreach (var type in typeConverters.Keys)
            {
                typeConverters[type] = typeConverter;
            }
        }

        /// <summary>
        /// Removes the <see cref="ITypeConverter"/> for the given <see cref="System.Type"/>.
        /// </summary>
        /// <param name="type">The type to remove the converter for.</param>
        public void RemoveConverter(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            typeConverters.Remove(type);
        }

        /// <summary>
        /// Removes the <see cref="ITypeConverter"/> for the given <see cref="System.Type"/>.
        /// </summary>
        /// <typeparam name="T">The type to remove the converter for.</typeparam>
        public void RemoveConverter<T>() { RemoveConverter(typeof(T)); }

        /// <summary>
        /// Gets the converter for the given <see cref="System.Type"/>.
        /// </summary>
        /// <param name="type">The type to get the converter for.</param>
        /// <returns>The <see cref="ITypeConverter"/> for the given <see cref="System.Type"/>.</returns>
        public ITypeConverter GetConverter(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            if (typeConverters.TryGetValue(type, out ITypeConverter typeConverter))
            {
                return typeConverter;
            }

            if (typeof(Enum).IsAssignableFrom(type))
            {
                if (typeConverters.TryGetValue(typeof(Enum), out typeConverter))
                {
                    // If the user has registered a converter for the generic Enum type,
                    // that converter will be used as a default for all enums. If a
                    // converter was registered for a specific enum type, it would be
                    // returned from above already.
                    return typeConverter;
                }

                AddConverter(type, new EnumConverter());
                return GetConverter(type);
            }

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                AddConverter(type, new NullableConverter(type, this));
                return GetConverter(type);
            }

            if (type.IsArray)
            {
                AddConverter(type, new ArrayGenericConverter());
                return GetConverter(type);
            }

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Dictionary<,>))
            {
                AddConverter(type, new DictionaryGenericConverter());
                return GetConverter(type);
            }

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(IDictionary<,>))
            {
                AddConverter(type, new DictionaryGenericConverter());
                return GetConverter(type);
            }

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            {
                AddConverter(type, new ListGenericConverter());
                return GetConverter(type);
            }

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Collection<>))
            {
                AddConverter(type, new ListGenericConverter());
                return GetConverter(type);
            }

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(IList<>))
            {
                AddConverter(type, new ListGenericConverter());
                return GetConverter(type);
            }

            if (type == typeof(Vector2))
            {
                AddConverter(type, new UnityVector2Converter());
                return GetConverter(type);
            }

            if (type == typeof(Vector3))
            {
                AddConverter(type, new UnityVector3Converter());
                return GetConverter(type);
            }

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(ICollection<>))
            {
                AddConverter(type, new ListGenericConverter());
                return GetConverter(type);
            }

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
            {
                AddConverter(type, new ListGenericConverter());
                return GetConverter(type);
            }

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Tuple<,>))
            {
                AddConverter(type, new PairGenericConverter());
                return GetConverter(type);
            }

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Tuple<,,>))
            {
                AddConverter(type, new Tuple3GenericConverter());
                return GetConverter(type);
            }

            // A specific IEnumerable converter doesn't exist.
            if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                return new EnumerableConverter();
            }

            return new DefaultTypeConverter();
        }

        /// <summary>
        /// Gets the converter for the given <see cref="System.Type"/>.
        /// </summary>
        /// <typeparam name="T">The type to get the converter for.</typeparam>
        /// <returns>The <see cref="ITypeConverter"/> for the given <see cref="System.Type"/>.</returns>
        public ITypeConverter GetConverter<T>() { return GetConverter(typeof(T)); }

        private void CreateDefaultConverters()
        {
            AddConverter(typeof(bool), new BooleanConverter());
            AddConverter(typeof(byte), new ByteConverter());
            AddConverter(typeof(byte[]), new ByteArrayConverter());
            AddConverter(typeof(char), new CharConverter());
            AddConverter(typeof(DateTime), new DateConverter("o"));
            AddConverter(typeof(DateTimeOffset), new DateTimeOffsetConverter());
            AddConverter(typeof(decimal), new DecimalConverter());
            AddConverter(typeof(double), new DoubleConverter());
            AddConverter(typeof(float), new SingleConverter());
            AddConverter(typeof(Guid), new GuidConverter());
            AddConverter(typeof(short), new Int16Converter());
            AddConverter(typeof(int), new Int32Converter());
            AddConverter(typeof(long), new Int64Converter());
            AddConverter(typeof(sbyte), new SByteConverter());
            AddConverter(typeof(string), new StringConverter());
            AddConverter(typeof(ushort), new UInt16Converter());
            AddConverter(typeof(uint), new UInt32Converter());
            AddConverter(typeof(ulong), new UInt64Converter());
            AddConverter(typeof(Uri), new UriConverter());
        }
    }
}