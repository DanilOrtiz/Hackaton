import { Routes } from '@angular/router';

import { AdminLayoutComponent } from './MaterialDashBoard/layouts/admin/admin-layout.component';
import {PantallaIncioComponent} from './Componentes/pantalla-incio/pantalla-incio.component';
import { UenFrmComponent } from './CertificacionDigital/components/uen-frm/uen-frm.component';
import { SprintFrmComponent } from './CertificacionDigital/components/sprint-frm/sprint-frm.component';
import { DepartamentoFrmComponent } from './CertificacionDigital/components/departamento-frm/departamento-frm.component';
import { SolicitanteFrmComponent } from './CertificacionDigital/components/solicitante-frm/solicitante-frm.component';


export const AppRoutes: Routes = [

    {
      path: '',
      component: AdminLayoutComponent, children: [
      {
        path: 'inicio',
        component: PantallaIncioComponent
      },
      {
        path: 'certificacion/uen',
        component: UenFrmComponent
      },
      {
        path: 'certificacion/sprint',
        component: SprintFrmComponent
      },
      {
        path: 'certificacion/departamento',
        component: DepartamentoFrmComponent
      },
      {
        path: 'certificacion/solicitante',
        component: SolicitanteFrmComponent
      },
      {path: '**', redirectTo: '/inicio', pathMatch: 'full'}
]}
];
