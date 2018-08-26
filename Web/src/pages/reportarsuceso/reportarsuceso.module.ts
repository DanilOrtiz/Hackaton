import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { ReportarsucesoPage } from './reportarsuceso';

@NgModule({
  declarations: [
    ReportarsucesoPage,
  ],
  imports: [
    IonicPageModule.forChild(ReportarsucesoPage),
  ],
  exports: [
    ReportarsucesoPage
  ]
})
export class ReportarsucesoPageModule {}
