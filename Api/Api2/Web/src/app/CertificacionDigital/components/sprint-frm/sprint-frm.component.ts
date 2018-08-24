import { Component, OnInit } from '@angular/core';
import { Sprint } from '../../models/certificacion-digital.model';
import { CertificacionDigitalService } from '../../services/certificacion-digital.service';
import { Alertas } from '../../../helpers/notificaciones/notificaciones';
import { DatePipe } from '@angular/common';
  
@Component({
  selector: 'app-sprint-frm',
  templateUrl: './sprint-frm.component.html',
  styleUrls: ['./sprint-frm.component.css']
})
export class SprintFrmComponent implements OnInit {
  sprint: Sprint;
  sprintEdit: Sprint;
  sprints: Sprint[];
  _mostrarPopup: boolean= false;
  
  constructor(private certificacionDigitalService: CertificacionDigitalService) {
  this.sprint = new Sprint();
  this.sprintEdit = new Sprint();
  this.obtenerSprints();
  }

  ngOnInit() {
  }

  obtenerSprints(): void{
    this.certificacionDigitalService.obtenerSprint().subscribe(data =>{
      this.sprints = data; 
    },error=>{
        Alertas.showHttpResponse(error);
    })
  }

  agregarSprint(): void{
      this.certificacionDigitalService.agregarSprint(this.sprint).subscribe(data =>{
      Alertas.ok("Exito");
      this.sprint = new Sprint();
      this.obtenerSprints();

    },error=>{
      console.log(error);
      Alertas.showHttpResponse(error);
    })

   }

   mostrarInformacionEnPoPup(sprint:Sprint){
    this.sprintEdit = sprint;
    this._mostrarPopup = true;
   }

   editarSprint(): void{

    this.certificacionDigitalService.editarSprint(this.sprintEdit).subscribe(data =>{
      Alertas.ok("Sprint Actualizado");
      this.sprintEdit = new Sprint();
      this._mostrarPopup = false;
    },error=>{
      this._mostrarPopup= false;
      Alertas.showHttpResponse(error);
    })

   }


}
