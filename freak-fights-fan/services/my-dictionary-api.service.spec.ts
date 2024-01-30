import { TestBed } from '@angular/core/testing';

import { MyDictionaryApiService } from './my-dictionary-api.service';

describe('MyDictionaryApiService', () => {
  let service: MyDictionaryApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MyDictionaryApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
