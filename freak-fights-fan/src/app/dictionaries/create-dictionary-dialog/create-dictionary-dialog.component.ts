import { Component, OnInit } from '@angular/core';
import { ReactiveFormsModule, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { CreateMyDictionary } from '../../../../shared/features/dictionaries/commands/CreateMyDictionary';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MyDictionaryService } from '../../../../services/my-dictionary.service';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-create-dictionary-dialog',
  standalone: true,
  imports: [MatDialogModule, MatFormFieldModule, ReactiveFormsModule, CommonModule, MatFormFieldModule, MatInputModule, MatButtonModule, MatIconModule],
  templateUrl: './create-dictionary-dialog.component.html',
  styleUrl: './create-dictionary-dialog.component.css'
})
export class CreateDictionaryDialogComponent {

  command: CreateMyDictionary.Command = {
    name: "",
    code: "",
  };

  createDictionaryForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private myDictionaryService: MyDictionaryService
  ) {
    this.createDictionaryForm = this.formBuilder.group({
      name: ["", [Validators.required]],
      code: ["", Validators.required]
    });
  }

  submit() {
    if (!this.createDictionaryForm.valid)
      return;

    this.command.name = this.createDictionaryForm.controls["name"].value;
    this.command.code = this.createDictionaryForm.controls["code"].value;

    this.myDictionaryService.createMyDictionary(this.command).subscribe({
      error: (e) => {
        console.error(e);
      }
    });
  }
}
