import { TestBed } from '@angular/core/testing';

import { MyDictionaryService } from './my-dictionary.service';

describe('MyDictionaryService', () => {
  let service: MyDictionaryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MyDictionaryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
