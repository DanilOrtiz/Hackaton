import { Component, OnInit } from '@angular/core';
import { Solicitante, Departamento, Usuario } from '../../models/certificacion-digital.model';
import { CertificacionDigitalService } from '../../services/certificacion-digital.service';
import { Alert, error } from 'selenium-webdriver';
import { Alertas } from '../../../helpers/notificaciones/notificaciones';
import { Console } from '@angular/core/src/console';
import list from 'devextreme/ui/list';
import { List } from 'linqts';
import { Observable } from 'rxjs/Observable';
import data_grid from 'devextreme/ui/data_grid';
import * as EmailValidator from 'email-validator';


@Component({
  selector: 'app-solicitante-frm',
  templateUrl: './solicitante-frm.component.html',
  styleUrls: ['./solicitante-frm.component.css']
})
export class SolicitanteFrmComponent implements OnInit {
  solicitante: Solicitante;
  solicitantes: Solicitante[];
  solicitanteEdit: Solicitante;
  departamentos: Departamento[];
  departamento: Departamento;
  departamentoEdit: Departamento;
  usuario: Usuario;
  usuarios: Array<Usuario>;
  _mostrarPopup: boolean;

  constructor(private certificacionDigitalService: CertificacionDigitalService) {
    this.solicitante = new Solicitante();
    this.solicitanteEdit = new Solicitante();
    this.departamento = new Departamento();
    this.departamentoEdit = new Departamento();
    this.usuario = new Usuario();
    this.usuarios = new Array<Usuario>();
    this._mostrarPopup = false;
    this.ObtenerSolicitantes();
    this.ObtenerUsuarios();
    this.ObtenerDepartamentos();

   }

  ngOnInit() {
  }

  ObtenerSolicitantes()
  {
    this.certificacionDigitalService.obtenerSolicitantes().subscribe(data=>{
         this.solicitantes = data;
      },error=>{
        Alertas.showHttpResponse(error);
      })

  }

  ObtenerDepartamentos()
  {
      this.certificacionDigitalService.obtenerDepartamentos().subscribe(data=>{
        this.departamentos=data;
        },error=>{
          Alertas.showHttpResponse(error);
        })

  }

  ObtenerUsuarios()
  {
    this.certificacionDigitalService.obtenerUsuarios().subscribe(data=>{
      this.usuarios = data;
    },error=>{
      Alertas.showHttpResponse(error);
    })
  }

  CargarInformacionDeUsuario(data)
  {
    if(data.value != 0)
    {
      this.usuario = this.usuarios.find(x => x.id == data.value);
      console.log(this.usuario);
    }
     
  }


  ValidarInformacionDeSolicitante(): boolean{

    if(this.usuario.nombreCompleto == "")
    {
      Alertas.error("El nombre del solicitante es requerido");
      return false;
    }

    if(this.usuario.nombreCompleto == undefined)
    {
      Alertas.error("El nombre del solicitante es requerido");
      return false;
    }


    if (EmailValidator.validate(this.usuario.correoElectronico) == false) 
    {
      Alertas.error("El correo del solisante no es valido");
      return false;
    }

    if(this.departamento.id == 0)
    {
      Alertas.error("Debe de seleccionar un departamento");
      return false;

    }

    return true;
  }

  AgregarSolicitante() {

    if (this.ValidarInformacionDeSolicitante() == false)
    {
      return;
    }

    this.solicitante.descripcion = this.usuario.nombreCompleto;
    this.solicitante.correo = this.usuario.correoElectronico;
    this.solicitante.telefono = this.usuario.telefono;
    this.solicitante.departamentoId = this.departamento.id;
    this.solicitante.usuarioId = this.usuario.id;

    this.certificacionDigitalService.agregarSolicitante(this.solicitante).subscribe(data=>{
      Alertas.ok("Solicitante agregado Exitosamente")
    },error=>{
      Alertas.showHttpResponse(error);
    })

  }

  MostrarInformacionDeSolicitanteEnPopup(solicitante:Solicitante)
  {
    this._mostrarPopup = true;
    this.solicitanteEdit = solicitante;
    this.departamentoEdit.id = this.solicitanteEdit.departamentoId;

  }

  ValidarInformacionDeSolicianteHaEditar(): boolean{

    if(this.solicitanteEdit.descripcion == "")
    {
      Alertas.error("El nombre del solicitante es requerido");
      return false;
    }

    if(this.solicitanteEdit.descripcion == undefined)
    {
      Alertas.error("El nombre del solicitante es requerido");
      return false;
    }


    if (EmailValidator.validate(this.solicitanteEdit.correo) == false) 
    {
      Alertas.error("El correo del solisante no es valido");
      return false;
    }

    if(this.departamentoEdit.id == 0)
    {
      Alertas.error("Debe de seleccionar un departamento");
      return false;

    }

    return true;
  }

  EditarSolicitante()
  {


    if (this.ValidarInformacionDeSolicianteHaEditar()==false)
    {
      this._mostrarPopup = false;
      return;
    }

    this.certificacionDigitalService.editarSolicitante(this.solicitanteEdit).subscribe(data=>{
      this._mostrarPopup = false;
      this.solicitanteEdit = new Solicitante();
      Alertas.ok("Solicitante editado exitosamente.");
       },error =>{
      this._mostrarPopup = false;
       Alertas.showHttpResponse(error);
      })

  }




}
