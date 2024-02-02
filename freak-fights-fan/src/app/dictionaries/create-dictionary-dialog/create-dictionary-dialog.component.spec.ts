import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateDictionaryDialogComponent } from './create-dictionary-dialog.component';

describe('CreateDictionaryDialogComponent', () => {
  let component: CreateDictionaryDialogComponent;
  let fixture: ComponentFixture<CreateDictionaryDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateDictionaryDialogComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateDictionaryDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
