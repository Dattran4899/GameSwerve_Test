﻿namespace CsvHelper.TypeConversion
{
    using System;
    using System.Numerics;

    public class UnityVector3Converter : DefaultTypeConverter
    {
        private readonly char delimiter;
        public UnityVector3Converter(char delimiter = ',') { this.delimiter = delimiter; }

        public override object ConvertFromString(string text, Type typeInfo)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var                 stringData = text.Split(this.delimiter);
                var                 x          = stringData[0];
                var                 y          = stringData[1];
                var                 Z          = stringData[2];
                IEquatable<Vector3> vector     = new Vector3(float.Parse(x), float.Parse(y), float.Parse(Z));
                return vector;
            }

            return null;
        }
    }
}