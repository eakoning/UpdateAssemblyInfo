﻿namespace Bool.PowerShell.UpdateAssemblyInfo
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Management.Automation;

    [Cmdlet(VerbsData.Update, "AssemblyInfo", ConfirmImpact = ConfirmImpact.Low, SupportsShouldProcess = false, SupportsTransactions = false)]
    public class UpdateAssemblyInfo : Cmdlet
    {
        private readonly AssemblyInfoUpdater updater;

        public UpdateAssemblyInfo()
        {
            this.updater = new AssemblyInfoUpdater();
        }

        protected override void ProcessRecord()
        {
            this.WriteDebug("ProcessRecord");
            this.updater.Cmdlet = this;
            this.updater.Files = this.Files;
            this.updater.AssemblyVersion = this.AssemblyVersion;
            this.updater.AssemblyFileVersion = this.AssemblyFileVersion;
            this.updater.AssemblyInformationalVersion = this.AssemblyInformationalVersion;

            this.updater.AssemblyCompany = this.AssemblyCompany;
            this.updater.AssemblyConfiguration = this.AssemblyConfiguration;
            this.updater.AssemblyCopyright = this.AssemblyCopyright;
            this.updater.AssemblyCulture = this.AssemblyCulture;
            this.updater.AssemblyDelaySign = this.AssemblyDelaySign;
            this.updater.AssemblyDescription = this.AssemblyDescription;
            this.updater.AssemblyKeyFile = this.AssemblyKeyFile;
            this.updater.AssemblyKeyName = this.AssemblyKeyName;
            this.updater.AssemblyProduct = this.AssemblyProduct;
            this.updater.AssemblyTitle = this.AssemblyTitle;
            this.updater.AssemblyTrademark = this.AssemblyTrademark;
            this.updater.CLSCompliant = this.CLSCompliant;
            this.updater.ComVisible = this.ComVisible;
            this.updater.Guid = this.Guid;
            this.updater.EnsureAttribute = this.EnsureAttribute;
            this.updater.CustomAttributes = this.CustomAttributes;
            var result = this.updater.InternalExecute();

            this.WriteObject(result);
        }
        
        /// <summary>
        ///     Sets the AssemblyInfo files to update.
        /// </summary>
        /// <remarks>
        ///     This property is <b>required.</b>
        /// </remarks>
        [Description("Specify the AssemblyInfo files path.")]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        public string[] Files { get; set; }

        /// <summary>
        ///     Sets the assembly version.
        /// </summary>
        /// <remarks>
        ///     <para>Setting the value to null will disable updating this attribute.</para>
        ///     <para>
        ///         The following tokens are supported (see <see cref="AssemblyInfoUpdater" /> remarks for a description of those
        ///         tokens):
        ///         <list type="bullet">
        ///             <item>
        ///                 <description>$(current)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(increment)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(date:&lt;format&gt;)</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        [Description("Specify the assembly version. (null to disable update)")]
        [Parameter()]
        public string AssemblyVersion { get; set; }

        /// <summary>
        ///     Sets the assembly file version.
        /// </summary>
        /// <remarks>
        ///     <para>Setting the value to null will disable updating this attribute.</para>
        ///     <para>
        ///         The following tokens are supported (see <see cref="AssemblyInfoUpdater" /> remarks for a description of those
        ///         tokens):
        ///         <list type="bullet">
        ///             <item>
        ///                 <description>$(current)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(increment)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(date:&lt;format&gt;)</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        [Description("Specify the assembly file version. (null to disable update)")]
        [Parameter()]
        public string AssemblyFileVersion { get; set; }

        /// <summary>
        ///     Sets the assembly informational version.
        /// </summary>
        /// <remarks>
        ///     <para>Setting the value to null will disable updating this attribute.</para>
        ///     <para>
        ///         The following tokens are supported (see <see cref="AssemblyInfoUpdater" /> remarks for a description of those
        ///         tokens):
        ///         <list type="bullet">
        ///             <item>
        ///                 <description>$(version)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(fileversion)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(date:&lt;format&gt;)</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        [Description("Specify the assembly informational version. (null to disable update)")]
        [Parameter()]
        public string AssemblyInformationalVersion { get; set; }

        /// <summary>
        ///     Sets the company name.
        /// </summary>
        /// <remarks>
        ///     <para>Setting the value to null will disable updating this attribute.</para>
        ///     <para>
        ///         The following tokens are supported (see <see cref="AssemblyInfoUpdater" /> remarks for a description of those
        ///         tokens):
        ///         <list type="bullet">
        ///             <item>
        ///                 <description>$(version)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(fileversion)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(date:&lt;format&gt;)</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        [Description("Specify the company name. (null to disable update)")]
        [Parameter()]
        public string AssemblyCompany { get; set; }

        /// <summary>
        ///     Sets the assembly configuration.
        /// </summary>
        /// <remarks>
        ///     <para>Setting the value to null will disable updating this attribute.</para>
        ///     <para>
        ///         The following tokens are supported (see <see cref="AssemblyInfoUpdater" /> remarks for a description of those
        ///         tokens):
        ///         <list type="bullet">
        ///             <item>
        ///                 <description>$(version)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(fileversion)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(date:&lt;format&gt;)</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        [Description("Specify the assembly configuration. (null to disable update)")]
        [Parameter()]
        public string AssemblyConfiguration { get; set; }

        /// <summary>
        ///     Sets the assembly copyright.
        /// </summary>
        /// <remarks>
        ///     <para>Setting the value to null will disable updating this attribute.</para>
        ///     <para>
        ///         The following tokens are supported (see <see cref="AssemblyInfoUpdater" /> remarks for a description of those
        ///         tokens):
        ///         <list type="bullet">
        ///             <item>
        ///                 <description>$(version)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(fileversion)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(date:&lt;format&gt;)</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        [Description("Specify the assembly copyright. (null to disable update)")]
        [Parameter()]
        public string AssemblyCopyright { get; set; }

        /// <summary>
        ///     Sets the assembly culture.
        /// </summary>
        /// <remarks>
        ///     Setting the value to null will disable updating this attribute.
        /// </remarks>
        [Description("Specify the assembly culture. (null to disable update)")]
        [Parameter()]
        public string AssemblyCulture { get; set; }

        /// <summary>
        ///     Set to <b>true</b> to mark the assembly for delay signing.
        /// </summary>
        /// <remarks>
        ///     Setting the value to null will disable updating this attribute.
        /// </remarks>
        [Description("Specify whether to delay sign the assembly. (null to disable update)")]
        [Parameter()]
        public bool? AssemblyDelaySign { get; set; }

        /// <summary>
        ///     Sets the assembly description.
        /// </summary>
        /// <remarks>
        ///     <para>Setting the value to null will disable updating this attribute.</para>
        ///     <para>
        ///         The following tokens are supported (see <see cref="AssemblyInfoUpdater" /> remarks for a description of those
        ///         tokens):
        ///         <list type="bullet">
        ///             <item>
        ///                 <description>$(version)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(fileversion)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(date:&lt;format&gt;)</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        [Description("Specify the assembly description. (null to disable update)")]
        [Parameter()]
        public string AssemblyDescription { get; set; }

        /// <summary>
        ///     Sets the assembly GUID.
        /// </summary>
        /// <remarks>
        ///     Setting the value to null will disable updating this attribute.
        /// </remarks>
        [Description("Specify the assembly GUID. (null to disable update)")]
        [Parameter()]
        public Guid? Guid { get; set; }

        /// <summary>
        ///     Sets the key file to use to sign the assembly.
        /// </summary>
        /// <remarks>
        ///     Setting the value to null will disable updating this attribute.
        /// </remarks>
        [Description("Specify the key file to use to sign the assembly. (null to disable update)")]
        [Parameter()]
        public string AssemblyKeyFile { get; set; }

        /// <summary>
        ///     Sets the name of a key container within the CSP containing the key pair used to generate a strong name.
        /// </summary>
        /// <remarks>
        ///     Setting the value to null will disable updating this attribute.
        /// </remarks>
        [Description("Specify the name of the key conteiner to use to generate a strong name. (null to disable update)")]
        [Parameter()]
        public string AssemblyKeyName { get; set; }

        /// <summary>
        ///     Sets the assembly product.
        /// </summary>
        /// <remarks>
        ///     <para>Setting the value to null will disable updating this attribute.</para>
        ///     <para>
        ///         The following tokens are supported (see <see cref="AssemblyInfoUpdater" /> remarks for a description of those
        ///         tokens):
        ///         <list type="bullet">
        ///             <item>
        ///                 <description>$(version)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(fileversion)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(date:&lt;format&gt;)</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        [Description("Specify the assembly product. (null to disable update)")]
        [Parameter()]
        public string AssemblyProduct { get; set; }

        /// <summary>
        ///     Sets the assembly title.
        /// </summary>
        /// <remarks>
        ///     <para>Setting the value to null will disable updating this attribute.</para>
        ///     <para>
        ///         The following tokens are supported (see <see cref="AssemblyInfoUpdater" /> remarks for a description of those
        ///         tokens):
        ///         <list type="bullet">
        ///             <item>
        ///                 <description>$(version)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(fileversion)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(date:&lt;format&gt;)</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        [Description("Specify the assembly title. (null to disable update)")]
        [Parameter()]
        public string AssemblyTitle { get; set; }

        /// <summary>
        ///     Sets the assembly trademark.
        /// </summary>
        /// <remarks>
        ///     <para>Setting the value to null will disable updating this attribute.</para>
        ///     <para>
        ///         The following tokens are supported (see <see cref="AssemblyInfoUpdater" /> remarks for a description of those
        ///         tokens):
        ///         <list type="bullet">
        ///             <item>
        ///                 <description>$(version)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(fileversion)</description>
        ///             </item>
        ///             <item>
        ///                 <description>$(date:&lt;format&gt;)</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        [Description("Specify the assembly trademark. (null to disable update)")]
        [Parameter()]
        public string AssemblyTrademark { get; set; }

        /// <summary>
        ///     Set to <b>true</b> to mark the assembly CLS compliant.
        /// </summary>
        /// <remarks>
        ///     Setting the value to null will disable updating this attribute.
        /// </remarks>
        [Description("Specify whether the assembly is CLS compliant. (null to disable update)")]
        [Parameter()]
        public bool? CLSCompliant { get; set; }

        /// <summary>
        ///     Set to <b>true</b> to make the assembly visible to COM.
        /// </summary>
        /// <remarks>
        ///     Setting the value to null will disable updating this attribute.
        /// </remarks>
        [Description("Specify whether the assembly is COM visible. (null to disable update)")]
        [Parameter()]
        public bool? ComVisible { get; set; }

        [Description("Specifiy whether or not to add missing attribute.")]
        [Parameter()]
        public bool? EnsureAttribute { get; set; }

        /// <summary>
        ///     Gets the custom attributes.
        /// </summary>
        [Description("Gets the custom attributes.")]
        [Parameter()]
        public Hashtable CustomAttributes { get; set; }
    }
}