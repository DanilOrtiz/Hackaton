import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

/**
 * Generated class for the RegisterPage page.
 *
 * See http://ionicframework.com/docs/components/#navigation for more info
 * on Ionic pages and navigation.
 */
@IonicPage()
@Component({
  selector: 'page-register',
  templateUrl: 'register.html',
})
export class RegisterPage {

  datos: FormGroup;
  constructor(public navCtrl: NavController,
             public navParams: NavParams,
             public formBuilder: FormBuilder) {
  this.datos = this.formBuilder.group({
                usuario: ['', Validators.required],
                contrasena: ['', [
                                    Validators.required,
                                    Validators.minLength(6)
                                ]
                            ],
            });
            }
            
  ionViewDidLoad() {
    console.log('ionViewDidLoad RegisterPage');
  }

}
