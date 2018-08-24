import { Component, OnInit } from '@angular/core';
import { Departamento, UEN } from '../../models/certificacion-digital.model';
import { CertificacionDigitalService } from '../../services/certificacion-digital.service';
import { Alertas } from '../../../helpers/notificaciones/notificaciones';
import { error } from 'selenium-webdriver';
import { debug } from 'util';

@Component({
  selector: 'app-departamento-frm',
  templateUrl: './departamento-frm.component.html',
  styleUrls: ['./departamento-frm.component.css']
})
export class DepartamentoFrmComponent implements OnInit {
  departamento:  Departamento;
  departamentoEdit:  Departamento;
  departamentos:  Departamento[];
  uens: UEN[];
  _mostrarPopup: boolean = false;

  constructor(private certificacionDigitalService: CertificacionDigitalService) {
    this.departamento = new Departamento();
    this.departamento.uen = new UEN();
    this.departamentoEdit = new Departamento();
    this.departamentoEdit.uen = new UEN();
    this.obtenerDepartamentos();
    this.obtenerUENs();
  }

  ngOnInit() {
  }

  obtenerDepartamentos(){
      this.certificacionDigitalService.obtenerDepartamentos().subscribe(data=>{
      this.departamentos = data;
     }, error=>{
      Alertas.showHttpResponse(error);
    })
 }

 obtenerUENs(){
    this.certificacionDigitalService.obtenerUENS().subscribe(data=>{
      this.uens = data;
      }, error=>{
        Alertas.showHttpResponse(error);
      })

 }

  agregarDepartamento(){

    this.certificacionDigitalService.agregarDepartamento(this.departamento).subscribe(data=>{
      this.departamento = new Departamento()
      this.obtenerDepartamentos();
      Alertas.ok("Departamento registrado exitosamente.");
    }, error=>{
      Alertas.showHttpResponse(error);
    })
  }

  editarDepartamento(){
   debugger
      this.certificacionDigitalService.editarDepartamento(this.departamentoEdit).subscribe(data=> {
        this._mostrarPopup = false
        Alertas.ok("Departamento Actualizado");
        this.obtenerDepartamentos();
      },error=>{
        Alertas.showHttpResponse(error);
      })


  }


  mostrarInformacionDeDepartamentoEnPopup(departamento:Departamento)
  {
      this.departamentoEdit = departamento;
      this._mostrarPopup = true;
  }

}
