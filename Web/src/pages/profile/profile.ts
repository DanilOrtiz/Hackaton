import { Component, ViewChild } from '@angular/core';
import { IonicPage, NavController, NavParams, ModalController, AlertController, PopoverController, App, Content } from 'ionic-angular';

import { ModalPost } from '../modal-post/modal-post';
import { EditProfile } from '../edit-profile/edit-profile';
import { Options } from '../options/options';
import { TaggedProfile } from '../tagged-profile/tagged-profile';
import { SavedProfile } from '../saved-profile/saved-profile';
import { AppService } from '../../services/app.service';
import { PostPopover } from '../home/post-popover';
import { Messages } from '../messages/messages';
import { Suceso, Categoria } from '../../models/app.models';

//@IonicPage()
@Component({
  selector: 'page-profile',
  templateUrl: 'profile.html',
})
export class Profile {
  sucesos: Suceso[];
  categorias: Categoria[];
  public like_btn = {
    color: 'black',
    icon_name: 'heart-outline'
  };
  @ViewChild(Content) content: Content;
  public tap: number = 0;
  public profile_segment:string;

  // You can get this data from your API. This is a dumb data for being an example.
  public images = [
    {
      id: 1,
      username: 'candelibas',
      profile_img: 'https://avatars1.githubusercontent.com/u/918975?v=3&s=120',
      post_img: 'https://scontent-cdg2-1.cdninstagram.com/t51.2885-15/e35/13473123_1544898359150795_654626889_n.jpg'
    },
    {
      id: 2,
      username: 'candelibas',
      profile_img: 'https://avatars1.githubusercontent.com/u/918975?v=3&s=120',
      post_img: 'https://scontent-cdg2-1.cdninstagram.com/t51.2885-15/e35/12940826_1673029922963013_921771297_n.jpg'
    },
    {
      id: 3,
      username: 'candelibas',
      profile_img: 'https://avatars1.githubusercontent.com/u/918975?v=3&s=120',
      post_img: 'https://scontent-cdg2-1.cdninstagram.com/t51.2885-15/e15/10852865_738738146215825_1258215298_n.jpg'
    },
    {
      id: 4,
      username: 'candelibas',
      profile_img: 'https://avatars1.githubusercontent.com/u/918975?v=3&s=120',
      post_img: 'https://scontent-cdg2-1.cdninstagram.com/t51.2885-15/e15/891528_841068522581102_1591061904_n.jpg'
    },
    {
      id: 5,
      username: 'candelibas',
      profile_img: 'https://avatars1.githubusercontent.com/u/918975?v=3&s=120',
      post_img: 'https://scontent-frx5-1.cdninstagram.com/t51.2885-15/e35/10809765_1474804169496730_887570428_n.jpg'
    },
    {
      id: 6,
      username: 'candelibas',
      profile_img: 'https://avatars1.githubusercontent.com/u/918975?v=3&s=120',
      post_img: 'https://scontent-cdg2-1.cdninstagram.com/t51.2885-15/e15/891515_1524153351163603_439436363_n.jpg'
    }
  ];

  constructor(public navCtrl: NavController, public navParams: NavParams, 
              public modalCtrl: ModalController,private alertCtrl: AlertController, 
              public popoverCtrl: PopoverController, public app: App,public appService: AppService) {  
                this.ObtenerSuceso();
                this.ObtenerCategorias();
  }

  // Define segment for everytime when profile page is active
  ionViewWillEnter() {
    this.profile_segment = 'grid';
  }

  goEditProfile() {
    // Open it as a modal page
    let modal = this.modalCtrl.create(EditProfile);
    modal.present();
  }

  goOptions() {
    this.navCtrl.push(Options, {});
  }

  goTaggedProfile() {
    this.navCtrl.push(TaggedProfile);
  }

  goSavedProfile() {
    this.navCtrl.push(SavedProfile);
  }

  // Triggers when user pressed a post
  pressPhoto(user_id: number, username: string, profile_img: string, post_img: string) {
    this.presentModal(user_id, username, profile_img, post_img);
  }

  // Set post modal
  presentModal(user_id: number, username: string, profile_img: string, post_img: string) {
    let modal = this.modalCtrl.create(ModalPost, 
    { // Send data to modal
      user_id: user_id, 
      username: username,
      profile_img: profile_img,
      post_img: post_img
    }, // This data comes from API!
    { showBackdrop: true, enableBackdropDismiss: true });
    modal.present();
  }
  ObtenerCategorias()
  {
    this.appService.ObtenerCategorias().subscribe(data => {
        this.categorias = data;
    });
  }

  ObtenerSuceso()
  {
    this.appService.ObtenerSucesosPorUsuario(1).subscribe(data => {
      this.sucesos = data;
      
      this.sucesos.forEach(suceso => {
        if (suceso.sucesoComentarios == null)
        {
          suceso.cantidadComentarios = 0;
        } else
        {
          suceso.cantidadComentarios = suceso.sucesoComentarios.length;
        }
        
        suceso.mostrarComentarios = false;
       
        if  (suceso.esAnonimo)
        {
          suceso.usuario.imagenUrl = "https://pbs.twimg.com/profile_images/962175011309043712/M44ZMbtf_400x400.jpg";
          suceso.usuario.nombre = "Anonimo";
          suceso.usuario.usuarioNombre = "Anonimo";
          suceso.usuario.apellido = "Anonimo";
        }

        console.log(this.sucesos);
      });

    }, error => {

    })
  }

  likeButton() {
    if(this.like_btn.icon_name === 'heart-outline') {
      this.like_btn.icon_name = 'heart';
      this.like_btn.color = 'danger';
      // Do some API job in here for real!
    }
    else {
      this.like_btn.icon_name = 'heart-outline';
      this.like_btn.color = 'black';
    }
  }

  tapPhotoLike(times) { // If we click double times, it will trigger like the post
    this.tap++;
    if(this.tap % 2 === 0) {
      this.likeButton();
    }
  }

  presentPostPopover() {
    let popover = this.popoverCtrl.create(PostPopover);
    popover.present();
  }

  goMessages() {
    this.app.getRootNav().push(Messages);
  }

  swipePage(event) {
    if(event.direction === 1) { // Swipe Left
      console.log("Swap Camera");
    } 

    if(event.direction === 2) { // Swipe Right
      this.goMessages();
    }
    
  }

  scrollToTop() {
    this.content.scrollToTop();
  }

  InsertarValoracion(valoracionId: any,sucesoId: any)
  {
    this.appService.InsertarValoracion(valoracionId,sucesoId,1).subscribe(data => {
      let alert = this.alertCtrl.create({
        title: 'Exito',
        subTitle: 'Valoración realizada con exito.',
        buttons: ['Cerrar']
      });
      alert.present();
    },error => {
      let alert = this.alertCtrl.create({
        title: 'Error',
        subTitle: 'Error al valorar Suceso',
        buttons: ['Cerrar']
      });
      alert.present();
    })
  }

  MostrarComentarios(sucesoId: any)
  {
    this.sucesos.forEach(suceso =>{
      if (suceso.id == sucesoId)
      {
        suceso.mostrarComentarios = true;            
        console.log(suceso);
      }
    });


  }


}
