import { Component } from '@angular/core';
import {  NavController, NavParams, AlertController } from 'ionic-angular';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AppService } from '../../services/app.service';
import { ConfirmarUsuario } from '../../models/app.models';
import { SecureStorage, SecureStorageObject } from '@ionic-native/secure-storage';
import { Home } from '../home/home';

/**
 * Generated class for the LoginPage page.
 *
 * See http://ionicframework.com/docs/components/#navigation for more info
 * on Ionic pages and navigation.
 */
@Component({
  selector: 'page-login',
  templateUrl: 'login.html',
})
export class LoginPage {
  [x: string]: any;


  Correo:string = "";
  ClaveNormal:string = "";

  public confirmarUsuario: ConfirmarUsuario
 
  constructor(public navCtrl: NavController,
             public navParams: NavParams,
             public formBuilder: FormBuilder,
             public appService: AppService,
             private secureStorage: SecureStorage,
             private alertCtrl: AlertController) {
               this.confirmarUsuario = new ConfirmarUsuario();
 }

  ConfirmarUsuario(){ 
    this.confirmarUsuario.Correo=this.Correo;
    this.confirmarUsuario.Clave=this.ClaveNormal;

    
    this.appService.ConfirmarCredenciales(this.confirmarUsuario).subscribe(
        data=> {
            if(data.respuestaTipo==0){
              this.RegistrarLocalStorage(data);
            } else {

              let alert = this.alertCtrl.create({
                title: 'Error',
                subTitle: 'Las credenciales son incrorrectass',
                buttons: ['Dismiss']
              });
              alert.present();
              this.Correo="";
              this.ClaveNormal="";
            }
        },error => {
          let alert = this.alertCtrl.create({
            title: 'Error',
            subTitle: 'Las credenciales son incrorrectass',
            buttons: ['Dismiss']
          });
          alert.present();
          this.Correo="";
          this.ClaveNormal="";

        })
  }

  RegistrarLocalStorage(usuario:ConfirmarUsuario){
   
      localStorage.setItem("key", JSON.stringify(usuario));
      this.navCtrl.push(Home);

  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad LoginPage');
  }

}
