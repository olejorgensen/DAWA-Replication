﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace GeoJSON.Net.Contrib.MsSqlSpatial.Sinks
{
    internal class SinkGeometryCollection<T> : List<SinkGeometry<T>>
    {
        public T GeometryType { get; set; }

        // For GEOMETRYCOLLECTION
        public List<SinkGeometryCollection<T>> SubItems { get; set; }

        public SinkGeometryCollection(T geomType)
        {
            GeometryType = geomType;
            SubItems = new List<SinkGeometryCollection<T>>();

        }
    }
}