# character-copy-kata

The character copier is a simple class that reads characters from a source and copies them to a destination one character at a time.

The character copier gets the source and destination injected in the constructor.

When the method Copy is called on the copier then it should read characters from the source and copy them to the destination until the source returns a newline (‘\n’).

The character copier class is written in such a way that it accepts mocks of source and destination using dependency injection, the tests for these are written using two options:

1) Manually written test (mocks)
2) Using a mocking framework (Moq)