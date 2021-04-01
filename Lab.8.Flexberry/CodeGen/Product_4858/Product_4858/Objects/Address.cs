﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Product_4858
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Address.
    /// </summary>
    // *** Start programmer edit section *** (Address CustomAttributes)

    // *** End programmer edit section *** (Address CustomAttributes)
    [PublishName("Адрес")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("SMC_AddressE", new string[] {
            "City as \'Город\'",
            "Country as \'Страна\'",
            "PostIndex as \'Почтовый индекс\'",
            "Street as \'Улица\'",
            "BuildingNumber as \'Номер здания\'"})]
    [View("SMC_AddressL", new string[] {
            "City as \'Город\'",
            "Country as \'Страна\'",
            "PostIndex as \'Почтовый индекс\'",
            "Street as \'Улица\'",
            "BuildingNumber as \'Номер здания\'"})]
    public class Address : ICSSoft.STORMNET.DataObject
    {
        
        private string fCity;
        
        private string fCountry;
        
        private string fPostIndex;
        
        private string fStreet;
        
        private int fBuildingNumber;
        
        // *** Start programmer edit section *** (Address CustomMembers)

        // *** End programmer edit section *** (Address CustomMembers)

        
        /// <summary>
        /// City.
        /// </summary>
        // *** Start programmer edit section *** (Address.City CustomAttributes)

        // *** End programmer edit section *** (Address.City CustomAttributes)
        [StrLen(255)]
        [PublishName("Город")]
        public virtual string City
        {
            get
            {
                // *** Start programmer edit section *** (Address.City Get start)

                // *** End programmer edit section *** (Address.City Get start)
                string result = this.fCity;
                // *** Start programmer edit section *** (Address.City Get end)

                // *** End programmer edit section *** (Address.City Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Address.City Set start)

                // *** End programmer edit section *** (Address.City Set start)
                this.fCity = value;
                // *** Start programmer edit section *** (Address.City Set end)

                // *** End programmer edit section *** (Address.City Set end)
            }
        }
        
        /// <summary>
        /// Country.
        /// </summary>
        // *** Start programmer edit section *** (Address.Country CustomAttributes)

        // *** End programmer edit section *** (Address.Country CustomAttributes)
        [StrLen(255)]
        [PublishName("Страна")]
        public virtual string Country
        {
            get
            {
                // *** Start programmer edit section *** (Address.Country Get start)

                // *** End programmer edit section *** (Address.Country Get start)
                string result = this.fCountry;
                // *** Start programmer edit section *** (Address.Country Get end)

                // *** End programmer edit section *** (Address.Country Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Address.Country Set start)

                // *** End programmer edit section *** (Address.Country Set start)
                this.fCountry = value;
                // *** Start programmer edit section *** (Address.Country Set end)

                // *** End programmer edit section *** (Address.Country Set end)
            }
        }
        
        /// <summary>
        /// PostIndex.
        /// </summary>
        // *** Start programmer edit section *** (Address.PostIndex CustomAttributes)

        // *** End programmer edit section *** (Address.PostIndex CustomAttributes)
        [StrLen(255)]
        [PublishName("Почтовый индекс")]
        public virtual string PostIndex
        {
            get
            {
                // *** Start programmer edit section *** (Address.PostIndex Get start)

                // *** End programmer edit section *** (Address.PostIndex Get start)
                string result = this.fPostIndex;
                // *** Start programmer edit section *** (Address.PostIndex Get end)

                // *** End programmer edit section *** (Address.PostIndex Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Address.PostIndex Set start)

                // *** End programmer edit section *** (Address.PostIndex Set start)
                this.fPostIndex = value;
                // *** Start programmer edit section *** (Address.PostIndex Set end)

                // *** End programmer edit section *** (Address.PostIndex Set end)
            }
        }
        
        /// <summary>
        /// Street.
        /// </summary>
        // *** Start programmer edit section *** (Address.Street CustomAttributes)

        // *** End programmer edit section *** (Address.Street CustomAttributes)
        [StrLen(255)]
        [PublishName("Улица")]
        public virtual string Street
        {
            get
            {
                // *** Start programmer edit section *** (Address.Street Get start)

                // *** End programmer edit section *** (Address.Street Get start)
                string result = this.fStreet;
                // *** Start programmer edit section *** (Address.Street Get end)

                // *** End programmer edit section *** (Address.Street Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Address.Street Set start)

                // *** End programmer edit section *** (Address.Street Set start)
                this.fStreet = value;
                // *** Start programmer edit section *** (Address.Street Set end)

                // *** End programmer edit section *** (Address.Street Set end)
            }
        }
        
        /// <summary>
        /// BuildingNumber.
        /// </summary>
        // *** Start programmer edit section *** (Address.BuildingNumber CustomAttributes)

        // *** End programmer edit section *** (Address.BuildingNumber CustomAttributes)
        [PublishName("Номер здания")]
        public virtual int BuildingNumber
        {
            get
            {
                // *** Start programmer edit section *** (Address.BuildingNumber Get start)

                // *** End programmer edit section *** (Address.BuildingNumber Get start)
                int result = this.fBuildingNumber;
                // *** Start programmer edit section *** (Address.BuildingNumber Get end)

                // *** End programmer edit section *** (Address.BuildingNumber Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Address.BuildingNumber Set start)

                // *** End programmer edit section *** (Address.BuildingNumber Set start)
                this.fBuildingNumber = value;
                // *** Start programmer edit section *** (Address.BuildingNumber Set end)

                // *** End programmer edit section *** (Address.BuildingNumber Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "SMC_AddressE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SMC_AddressE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SMC_AddressE", typeof(IIS.Product_4858.Address));
                }
            }
            
            /// <summary>
            /// "SMC_AddressL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SMC_AddressL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SMC_AddressL", typeof(IIS.Product_4858.Address));
                }
            }
        }
    }
}
