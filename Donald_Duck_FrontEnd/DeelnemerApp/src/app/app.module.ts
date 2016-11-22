import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule} from "@angular/forms";
import { HttpModule } from '@angular/http';
import { DeelnemerModule } from './deelnemer/deelnemer.module'
import { DeelnemerService } from './deelnemer/deelnemer.service'

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    DeelnemerModule
  ],
  providers: [DeelnemerService],
  bootstrap: [AppComponent]
})
export class AppModule { }
