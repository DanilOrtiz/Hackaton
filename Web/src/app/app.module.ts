import { NgModule, ErrorHandler } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { IonicApp, IonicModule, IonicErrorHandler } from 'ionic-angular';
import { MyApp } from './app.component';

import { Home } from '../pages/home/home';
import { PostPopover } from '../pages/home/post-popover';
import { Search } from '../pages/search/search';
import { ModalPost } from '../pages/modal-post/modal-post';
import { Messages } from '../pages/messages/messages';
import { MessageDetail } from '../pages/message-detail/message-detail';
import { NewMessage } from '../pages/new-message/new-message';
import { Notifications } from '../pages/notifications/notifications';
import { Profile } from '../pages/profile/profile';
import { EditProfile } from '../pages/edit-profile/edit-profile';
import { TaggedProfile } from '../pages/tagged-profile/tagged-profile';
import { SavedProfile } from '../pages/saved-profile/saved-profile';
import { Options } from '../pages/options/options';
import { Comments } from '../pages/comments/comments';
import { TabsPage } from '../pages/tabs/tabs';

import { StatusBar } from '@ionic-native/status-bar';
import { SplashScreen } from '@ionic-native/splash-screen';
import { Camera } from '@ionic-native/camera';
import { AppService } from '../services/app.service';
import { HttpModule } from '@angular/http';

import { LoginPage } from "../pages/login/login";
import { RegisterPage } from "../pages/register/register";
import { SecureStorage } from '@ionic-native/secure-storage';

@NgModule({
  declarations: [
    MyApp,
    Home,
    PostPopover,
    Search,
    ModalPost,
    Messages,
    MessageDetail,
    NewMessage,
    Notifications,
    Profile,
    EditProfile,
    TaggedProfile,
    SavedProfile,
    Options,
    Comments,
    TabsPage,
    LoginPage,
    RegisterPage,
  ],
  imports: [
    BrowserModule,
    HttpModule,
        IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    Home,
    PostPopover,
    Search,
    ModalPost,
    Messages,
    MessageDetail,
    NewMessage,
    Notifications,
    Profile,
    EditProfile,
    TaggedProfile,
    SavedProfile,
    Options,
    Comments,
    TabsPage,
    LoginPage,
    RegisterPage
  ],
  providers: [
    SecureStorage,
    StatusBar,
    SplashScreen,
    Camera,
    AppService,
    {provide: ErrorHandler, useClass: IonicErrorHandler,}
  ]
})
export class AppModule {}
