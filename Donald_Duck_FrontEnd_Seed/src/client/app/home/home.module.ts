import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../shared/shared.module';
import { HomeComponent } from './home.component';
import { NameListService } from '../shared/name-list/index';
import { FormsModule, ReactiveFormsModule} from "@angular/forms";

@NgModule({
  imports: [CommonModule, SharedModule, ReactiveFormsModule, FormsModule],
  declarations: [HomeComponent],
  exports: [HomeComponent],
  providers: [NameListService]
})
export class HomeModule { }
