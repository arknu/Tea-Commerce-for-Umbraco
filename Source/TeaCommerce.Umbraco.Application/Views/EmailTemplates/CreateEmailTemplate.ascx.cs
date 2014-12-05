﻿using System;
using System.Web.UI;
using TeaCommerce.Api.Models;
using TeaCommerce.Umbraco.Application.Resources;
using TeaCommerce.Umbraco.Application.UI;
using TeaCommerce.Umbraco.Application.Utils;

namespace TeaCommerce.Umbraco.Application.Views.EmailTemplates {
  public partial class CreateEmailTemplate : StoreSpecificUserControl {

    protected override void OnInit( EventArgs e ) {
      base.OnInit( e );

      LitName.Text = CommonTerms.Name;
      BtnCreate.Text = CommonTerms.Create;
      LitOr.Text = CommonTerms.Or;
      LitCancel.Text = CommonTerms.Cancel;
    }

    protected void BtnCreate_Click( object sender, EventArgs e ) {
      if ( Page.IsValid ) {
        EmailTemplate emailTemplate = new EmailTemplate( StoreId, TxtName.Text );
        emailTemplate.Save();
        base.Redirect( WebUtils.GetPageUrl( Constants.Pages.EditEmailTemplate ) + "?id=" + emailTemplate.Id + "&storeId=" + emailTemplate.StoreId );
      }

    }

  }
}