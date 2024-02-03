import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateDictionaryDialogComponent } from './update-dictionary-dialog.component';

describe('UpdateDictionaryDialogComponent', () => {
  let component: UpdateDictionaryDialogComponent;
  let fixture: ComponentFixture<UpdateDictionaryDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UpdateDictionaryDialogComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UpdateDictionaryDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
