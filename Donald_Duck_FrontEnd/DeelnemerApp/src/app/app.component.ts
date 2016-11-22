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

  deelnemers : IDeelnemer[] = [];
  registerForm : FormGroup;

  constructor(private deelnemerService: DeelnemerService, private formBuilder: FormBuilder) {
    deelnemerService.getDeelnemers(this.deelnemers);
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

  startEditing(model: any) {
    model._isEditing = true;
  }

  stopEditing(model: any){
    if(!!model._backup){
      delete model._backup;
    }
    model._isEditing = false;
  }

  cancel(model: any) {
    this.stopEditing(model);
  }

  update(model: IDeelnemer) {
    this.deelnemerService.updateDeelnemer(model);
    this.stopEditing(model);
  }

  copyObject<T> (object:T): T {
    var objectCopy = <T>{};

    for (var key in object)
    {
        if (object.hasOwnProperty(key))
        {
            objectCopy[key] = object[key];
        }
    }

    return objectCopy;
  }

  //Example of Listener for (event driven) response
  /*
  responseListener(timeOutAfter : number){
    let timerId : number;
    let time : number = 0;
    timerId = setInterval(100, function(){
      time +=100;
      var result = this.deelnemerService.reveivedDeelnemerCreated();
      if(result.filled && time < timeOutAfter){
        clearInterval(timerId);
      }
    });
  }
  */
}
