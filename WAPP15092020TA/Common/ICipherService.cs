namespace WAPP15092020TA.Common
{
    public interface ICipherService
    {
        string Decrypt(string cipherText);
        string Encrypt(string input);
    }
}