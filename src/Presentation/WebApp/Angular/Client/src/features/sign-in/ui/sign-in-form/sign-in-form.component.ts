import { Component, EventEmitter, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Store } from '@ngrx/store';
import { sessionModel } from '~entities/session';
import { LoginUserDto } from '~entities/session/model/types';

@Component({
  selector: 'sign-in-form',
  templateUrl: './sign-in-form.component.html',
  styleUrl: './sign-in-form.component.scss'
})
export class SignInFormComponent {
  @Output() onComplete = new EventEmitter<string>();
  form: FormGroup = this.formBuilder.group({
    username: ['', Validators.required],
    password: ['', Validators.required]
  });
  isSubmitted: boolean = false;

  constructor(
    private formBuilder: FormBuilder,
    private readonly store: Store
  ) { }

  onSubmitLogin(): void {
    this.isSubmitted = true;
    this.form.markAsTouched();

    if (this.form.invalid)
      return;

    const loginUserDto: LoginUserDto = {
      username: this.form.get('username')?.value ?? '',
      password: this.form.get('password')?.value ?? ''
    };

    this.store.dispatch(sessionModel.actions.loginUser({ loginUserDto }));

    this.store.select(sessionModel.selectors.selectIsAuthorized)
      .subscribe(isAuthorized => {
        if (!isAuthorized)
          return;

        this.store.select(sessionModel.selectors.selectRedirectionPath)
          .subscribe(redirectionPath => this.onComplete.emit(redirectionPath));
      });
  }

  get isInvalidPassword(): boolean {
    let isInvalid = this.form.controls['password'].invalid
      && (this.form.controls['password'].dirty || this.form.controls['password'].touched)
      || this.form.controls['password'].invalid && this.isSubmitted;

    return isInvalid;
  }

  get isInvalidUsername(): boolean {
    let isInvalid = this.form.controls['username'].invalid
      && (this.form.controls['username'].dirty || this.form.controls['username'].touched)
      || this.form.controls['username'].invalid && this.isSubmitted;

    return isInvalid;
  }
}
