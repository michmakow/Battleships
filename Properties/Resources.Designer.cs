﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Battleships.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Battleships.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Coordinates: {0}{1}! Roger!.
        /// </summary>
        internal static string Coordinates {
            get {
                return ResourceManager.GetString("Coordinates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter coordinates: .
        /// </summary>
        internal static string EnterCoordinates {
            get {
                return ResourceManager.GetString("EnterCoordinates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Firing!!!!.
        /// </summary>
        internal static string Firing {
            get {
                return ResourceManager.GetString("Firing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You already hit this spot sailor!!.
        /// </summary>
        internal static string SameSpot {
            get {
                return ResourceManager.GetString("SameSpot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nice shoot!!! You hit {0}!.
        /// </summary>
        internal static string ShipHit {
            get {
                return ResourceManager.GetString("ShipHit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Almost captain!!! Miss!.
        /// </summary>
        internal static string ShipMissed {
            get {
                return ResourceManager.GetString("ShipMissed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You sunk {0}! Congrats captain!!!.
        /// </summary>
        internal static string ShipSunk {
            get {
                return ResourceManager.GetString("ShipSunk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thanks for playing sailor. Have a nice day!!!.
        /// </summary>
        internal static string ThanksForPlaying {
            get {
                return ResourceManager.GetString("ThanksForPlaying", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To much RUM sailor? Stop mumbling.
        /// </summary>
        internal static string WrongInput {
            get {
                return ResourceManager.GetString("WrongInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You WON captain!! Thank You for playing!!!.
        /// </summary>
        internal static string YouWon {
            get {
                return ResourceManager.GetString("YouWon", resourceCulture);
            }
        }
    }
}
