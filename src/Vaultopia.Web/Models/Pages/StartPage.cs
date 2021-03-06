﻿using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using ImageVault.EPiServer;
using Vaultopia.Web.Models.Blocks;

namespace Vaultopia.Web.Models.Pages {
    [ContentType(DisplayName = "Home", GUID = "2c4be70b-20cf-4e10-ad51-52bdd98b99f7", Description = "")]
    public class StartPage : SitePageData {

        /// <summary>
        /// Gets or sets the teasers.
        /// </summary>
        /// <value>
        /// The teasers.
        /// </value>
        [CultureSpecific]
        [Editable(true)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentArea Teasers { get; set; }

        /// <summary>
        /// Gets or sets the wide teasers.
        /// </summary>
        /// <value>
        /// The wide teasers.
        /// </value>
        [CultureSpecific]
        [Editable(true)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentArea WideTeasers { get; set; }

        /// <summary>
        /// Gets or sets the first site testimonial.
        /// </summary>
        /// <value>
        /// The first site testimonial.
        /// </value>
        [Display(GroupName = SystemTabNames.Content)]
        public virtual SiteTestimonialBlock FirstSiteTestimonial { get; set; }

        /// <summary>
        /// Gets or sets the second site testimonial.
        /// </summary>
        /// <value>
        /// The second site testimonial.
        /// </value>
        [Display(GroupName = SystemTabNames.Content)]
        public virtual SiteTestimonialBlock SecondSiteTestimonial { get; set; }

        /// <summary>
        /// Gets or sets the inspiration.
        /// </summary>
        /// <value>
        /// The inspiration.
        /// </value>
        [Display(GroupName = SystemTabNames.Content)]
        public virtual SiteInspirationBlock SiteInspiration { get; set; }

        /// <summary>
        /// Gets or sets the media list.
        /// </summary>
        /// <value>
        /// The media list.
        /// </value>
        [Display(GroupName = SystemTabNames.Content)]
        [BackingType(typeof(PropertyMediaList))]
        public virtual MediaReferenceList<MediaReference> PushMediaList { get; set; }
    }
}