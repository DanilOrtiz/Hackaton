import { Component } from '@angular/core';

import { Home } from '../home/home';
import { Search } from '../search/search';
import { Notifications } from '../notifications/notifications';
import { Profile } from '../profile/profile';
import{ ReportarsucesoPage } from'../reportarsuceso/reportarsuceso';


import { LoginPage } from "../login/login";
import { RegisterPage } from "../register/register";


import { Camera, CameraOptions } from '@ionic-native/camera';

import { App, NavController } from 'ionic-angular';

@Component({
  templateUrl: 'tabs.html'
})
export class TabsPage {

  tab1Root = Home;
  tab2Root = Search;
  tab3Root=  ReportarsucesoPage;
  tab4Root = Notifications;
  tab5Root = Profile;

  constructor(private camera: Camera,
    public app: App,
    public navCtrl: NavController
  ) {
 
  }

  ValidarUsuario(){
    let identity = localStorage.getItem('key'); //.then( data => this.name = data, console.error('Error getting LoginData', error));
    
    
      if(identity == null){
        this.navCtrl.push(LoginPage);
      }else{
        this.navCtrl.push(Profile);
      }

   // return this.identity;
  }

  openCamera() {
    const options: CameraOptions = {
      quality: 100,
      destinationType: this.camera.DestinationType.DATA_URL,
      encodingType: this.camera.EncodingType.JPEG,
      mediaType: this.camera.MediaType.PICTURE
    }

    this.camera.getPicture(options).then((imageData) => {
      // imageData is either a base64 encoded string or a file URI
      // If it's base64:
      let base64Image = 'data:image/jpeg;base64,' + imageData;
    }, (err) => {
      // Handle error
    });
  }
}
