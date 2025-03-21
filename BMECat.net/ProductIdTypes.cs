﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BMECat.net
{
    /// <summary>
    /// This element contains the product number issued by the supplier. It is determining for ordering the product; it identifies 
    /// the product in the supplier catalog. In multi-supplier
    /// catalogs, however, only the combination of SUPPLIER_PID and SUPPLIER_IDREF identifies a product.
    /// 
    /// Please note:
    /// Some target systems are not able to accept all 32 characters (e.g., SAP max. 18 characters). It is therefore 
    /// advisable to keep product identifications as short as possible
    /// </summary>
    public enum ProductIdTypes
    {
        /// <summary> Artikelnummer des einkaufenden Unternehmen </summary>
        BuyerSpecific,

        /// <summary> Europäische Artikelnummer (14 Zeichen), s. http://www.ean-int.org </summary>
        EAN,

        /// <summary> Global Trade Item Number, s. http://www.uc-council.org/2005sunrise/global_trade_item_number.html </summary>
        GTIN,

        /// <summary> Artikelnummer des Lieferanten </summary>
        SupplierSpecific,

        /// <summary> Universal Product Code, s. http://www.ean.de/ean/Inhalt/e2/e8/e335</summary>
        UPC,

        /// <summary>
        /// Unknown (error) value
        /// </summary>
        Unknown
    }

    
    internal static class ProductIdTypesExtensions
    {
        public static ProductIdTypes FromString(this ProductIdTypes _, string s)
        {
            s = s.ToLower().Trim();
            switch (s)
            {
                case "buyer_specific": return ProductIdTypes.BuyerSpecific;
                case "ean": return ProductIdTypes.EAN;
                case "gtin": return ProductIdTypes.GTIN;
                case "supplier_specific": return ProductIdTypes.SupplierSpecific;
                case "upc": return ProductIdTypes.UPC;

                default: return ProductIdTypes.Unknown;
            }
        } // !FromString()


        public static string EnumToString(this ProductIdTypes c)
        {
            switch (c)
            {
                case ProductIdTypes.BuyerSpecific: return "buyer_specific";
                case ProductIdTypes.EAN: return "ean";
                case ProductIdTypes.GTIN: return "gtin";
                case ProductIdTypes.SupplierSpecific: return "supplier_specific";
                case ProductIdTypes.UPC: return "upc";

                default: return "";
            }
        } // !ToString()
    }
}

