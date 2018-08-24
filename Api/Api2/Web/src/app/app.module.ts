import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import {FooterModule} from './MaterialDashBoard/shared/footer/footer.module';
import {NavbarModule} from './MaterialDashBoard/shared/navbar/navbar.module';
import {SidebarModule} from './MaterialDashBoard/sidebar/sidebar.module';

import {AdminLayoutComponent} from './MaterialDashBoard/layouts/admin/admin-layout.component';
import { AppRoutes } from './app.routing';

import { PantallaIncioComponent } from './Componentes/pantalla-incio/pantalla-incio.component';
import { UenFrmComponent } from './CertificacionDigital/components/uen-frm/uen-frm.component';

import {
  DxLookupModule,
  DxTextBoxModule,
  DxTabsModule,
  DxValidatorModule,
  DxCheckBoxModule,
  DxDataGridModule,
  DxPopupModule,
  DxTextAreaModule,
  DxButtonModule,
  DxDateBoxModule,
  DxFormModule,
  DxSelectBoxModule,
  DxFormComponent,
  DxResponsiveBoxModule,
} from "devextreme-angular";
import { CertificacionDigitalService } from './CertificacionDigital/services/certificacion-digital.service';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import { SprintFrmComponent } from './CertificacionDigital/components/sprint-frm/sprint-frm.component';
import { CommonModule } from '@angular/common';
import { DepartamentoFrmComponent } from './CertificacionDigital/components/departamento-frm/departamento-frm.component';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { SolicitanteFrmComponent } from './CertificacionDigital/components/solicitante-frm/solicitante-frm.component';
import { List } from 'linqts';

@NgModule({
  declarations: [
    AppComponent,
    AdminLayoutComponent,
    PantallaIncioComponent,
    UenFrmComponent,
    SprintFrmComponent,
    DepartamentoFrmComponent,
    SolicitanteFrmComponent
  ],
  imports: [
    BrowserModule,
    NavbarModule,
    FooterModule,
    SidebarModule,
    FormsModule ,
    RouterModule.forRoot(AppRoutes),
    DxLookupModule,
    DxTextBoxModule,
    DxTabsModule,
    DxValidatorModule,
    DxCheckBoxModule,
    DxDataGridModule,
    DxPopupModule,
    DxTextAreaModule,
    DxButtonModule,
    HttpModule,
    DxDateBoxModule,
    DxFormModule,
    DxSelectBoxModule,
		DxTextAreaModule,
		DxDateBoxModule,
    DxFormModule,
    DxResponsiveBoxModule
     ],
  providers: [CertificacionDigitalService],
  bootstrap: [AppComponent]
})
export class AppModule { }


platformBrowserDynamic().bootstrapModule(AppModule);
