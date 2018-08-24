import { Component, OnInit } from '@angular/core';
import { UEN } from '../../models/certificacion-digital.model';
import { CertificacionDigitalService } from '../../services/certificacion-digital.service';
import { Alertas } from '../../../helpers/notificaciones/notificaciones';
import { NgModule } from '@angular/core';

@Component({
 moduleId: module.id,
  templateUrl: 'uen-frm.component.html'
})
export class UenFrmComponent implements OnInit {
  uen: UEN;
  uenEdit: UEN;
  uens: UEN[];
  _mostrarPopup:boolean=false;
  
  constructor(private certificacionDigitalSerivce: CertificacionDigitalService) {
   this.uen = new UEN();
   this.uenEdit = new UEN();
   this.ObtenerUENS();
   }


  ngOnInit() {
  }


  ObtenerUENS(): void{
    this.certificacionDigitalSerivce.obtenerUENS().subscribe(data =>{
         this.uens = data;
    })

    }  

   AgregarUEN(): void{
    
    if (this.ValidarDatos(this.uen) == false)
    {
      Alertas.info("Información","La descripción no puede quedar vacia.")
      return;
    }

    this.certificacionDigitalSerivce.agregarUEN(this.uen).subscribe(x =>{
      Alertas.ok("Exito");
      this.uen = new UEN();
      this.ObtenerUENS();
    }, error =>{
      Alertas.showHttpResponse(error);
    })
   }
   

   mostrarInformacionUENenPoPup(uen:UEN)
   {
      this.uenEdit.descripcion = uen.descripcion;
      this.uenEdit.id = uen.id;
      this.uenEdit.activo = uen.activo;
      this._mostrarPopup = true;
   }

   editarUEN(): void
   {
      if(this.uenEdit.descripcion == "")
      {
          this._mostrarPopup = false;
          Alertas.info("Información","La descripción no puede quedar vacia.");
          this.uenEdit =new UEN();
          return;
      }

      this.certificacionDigitalSerivce.editarUEN(this.uenEdit).subscribe(x =>{
        this._mostrarPopup = false;
        Alertas.ok("Registro Actualizado");
        this.uenEdit = new UEN();
        this.ObtenerUENS();        
        }, error =>{
          this._mostrarPopup = false
            Alertas.showHttpResponse(error);
        })

   }

   
   ValidarDatos(uen): boolean{

    if(uen.descripcion == "")
    {
      return false;
    }
     return true;
   }

  }


