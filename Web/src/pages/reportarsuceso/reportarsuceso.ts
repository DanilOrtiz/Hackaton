import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { AlertController } from 'ionic-angular';

/**
 * Generated class for the ReportarsucesoPage page.
 *
 * See http://ionicframework.com/docs/components/#navigation for more info
 * on Ionic pages and navigation.
 */
@IonicPage()
@Component({
  selector: 'page-reportarsuceso',
  templateUrl: 'reportarsuceso.html',
})
export class ReportarsucesoPage {



  constructor(public navCtrl: NavController, public navParams: NavParams, public alertCtrl: AlertController) {


  }
  presentConfirm() {
    let tipo = null;
    let alert = this.alertCtrl.create({
      title: 'Especifica como deseas reportar',
      message: '¿Como deseas reportar?',
      buttons: [
        {
          text: 'Rapido',

          handler: () => {
            tipo=true;
            console.log('Rapido clicked'+tipo);
          }

        },
        {
          text: 'Detallado',
          handler: () => {
            tipo=false;
            console.log('Detallado clicked'+tipo);
          }
        }
      ]

    });
    alert.present();
    return tipo;
  }

  ionViewDidEnter(){
    this.presentConfirm();
  }

}
