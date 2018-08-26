import { Component, ViewChild } from '@angular/core';
import { App, NavController, Content, PopoverController, AlertController } from 'ionic-angular';
import { PostPopover } from './post-popover';
import { Messages } from '../messages/messages';
import { Suceso, Categoria } from '../../models/app.models';
import { AppService } from '../../services/app.service';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class Home {
  [x: string]: any;
  @ViewChild(Content) content: Content;

  sucesos: Suceso[];
  categorias: Categoria[];
  public like_btn = {
    color: 'black',
    icon_name: 'heart-outline'
  };

  public tap: number = 0;

  // You can get this data from your API. This is a dumb data for being an example.
  public stories = [
    {
      id: 1,
      img: 'https://www.ochbuffalo.org/sites/default/files/inline-images/KH-15733-OSHEI-SIGN-RENDERING_cmyk.jpg',
      user_name: 'Hospital'
    },
    {
      id: 2,
      img: 'http://www.ruraliberica.com/archivo/fotos/policia%20local%201.jpg',
      user_name: 'Policia'
    },
    {
      id: 3,
      img: 'http://ionicframework.com/dist/preview-app/www/assets/img/sarah-avatar.png.jpeg',
      user_name: 'ashleyosama'
    },
    {
      id: 4,
      img: 'https://pbs.twimg.com/profile_images/479090794058379264/84TKj_qa_400x400.jpeg',
      user_name: 'adam_bradley'
    },
    {
      id: 5,
      img: 'https://avatars1.githubusercontent.com/u/1024025?v=3&s=120',
      user_name: 'linus_torvalds'
    }
    
  ];

  constructor(private alertCtrl: AlertController,public navCtrl: NavController, public popoverCtrl: PopoverController, public app: App,public appService: AppService) {
    this.ObtenerSuceso();
    this.ObtenerCategorias();
  }

  ObtenerCategorias()
  {
    this.appService.ObtenerCategorias().subscribe(data => {
        this.categorias = data;
    });
  }

  ObtenerSuceso()
  {
    this.appService.ObtenerTopSuceso().subscribe(data => {
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
