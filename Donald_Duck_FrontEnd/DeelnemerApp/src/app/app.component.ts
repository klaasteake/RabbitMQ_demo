import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';
import { IDeelnemer, FullnamePipe, DeelnemerService } from './deelnemer';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app works!';

  deelnemers : IDeelnemer[];
  registerForm : FormGroup;

  constructor(private deelnemerService: DeelnemerService, private formBuilder: FormBuilder) {
    this.deelnemers = deelnemerService.getDeelnemers();
  }

  ngOnInit() {
    this.registerForm = this.formBuilder.group({
      firstName: ['', [Validators.required]],
      lastName: ['', [Validators.required]],
      bSN: ['', [Validators.required, Validators.pattern(/^[0-9]{8,9}$/)]],
      birthDate: [new Date(), [Validators.required]]
    });
  }

  register(model: IDeelnemer, isValid: boolean) {
    // check if model is valid
    // if valid, call API to save customer
    console.log(model, isValid);
    if(isValid){
      this.deelnemers.push(model);
      this.deelnemerService.addDeelnemer(model);
      this.registerForm.reset();
    }
  }

  update(model: IDeelnemer) {
    console.log(model);
    this.deelnemerService.updateDeelnemer(model);
  }
}
