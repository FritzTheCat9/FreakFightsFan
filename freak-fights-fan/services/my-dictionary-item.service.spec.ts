import { TestBed } from '@angular/core/testing';

import { MyDictionaryItemService } from './my-dictionary-item.service';

describe('MyDictionaryItemService', () => {
  let service: MyDictionaryItemService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MyDictionaryItemService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
