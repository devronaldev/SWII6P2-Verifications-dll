# SWII6P2Verifications - Biblioteca de Verificações

## Descrição do Projeto
A biblioteca `SWII6P2Verifications` contém métodos estáticos para realizar verificações básicas de dados relacionados a produtos e usuários, garantindo que os campos obrigatórios estejam preenchidos corretamente antes de prosseguir com as operações.

## Funcionalidades
A biblioteca oferece as seguintes verificações:

### 1. **Verificação de Produto**
   - **Método:** `IsProductFull`
   - **Descrição:** Verifica se o nome do produto e o preço estão preenchidos corretamente.
   - **Parâmetros:**
     - `name` (string): O nome do produto.
     - `price` (double): O preço do produto.
   - **Retorno:** 
     - `true`: Se o nome não for vazio ou nulo e o preço for diferente de zero.
     - `false`: Caso contrário.

### 2. **Verificação de Usuário**
   - **Método:** `IsUserFull`
   - **Descrição:** Verifica se o nome e a senha do usuário estão preenchidos corretamente.
   - **Parâmetros:**
     - `name` (string): O nome do usuário.
     - `password` (string): A senha do usuário.
   - **Retorno:** 
     - `true`: Se o nome e a senha não forem vazios ou nulos.
     - `false`: Caso contrário.

## Tecnologias Utilizadas
- **C# (.NET):** A biblioteca foi desenvolvida utilizando C# no ambiente .NET, oferecendo métodos estáticos fáceis de utilizar para validações rápidas.

## Como Utilizar

1. **Referenciando a DLL:**
   - Adicione a referência ao projeto ou DLL `SWII6P2Verifications` no seu projeto.
   
2. **Chamando os Métodos:**
   - Para verificar se os dados do produto estão completos, utilize o método `IsProductFull`:
     ```csharp
     bool isProductValid = Verifications.IsProductFull(productName, productPrice);
     ```
   - Para verificar se os dados do usuário estão completos, utilize o método `IsUserFull`:
     ```csharp
     bool isUserValid = Verifications.IsUserFull(userName, userPassword);
     ```

## Créditos
<table>
  <tr>
    <td>
      Prontuário
    </td>
    <td>
      Nome Completo
    </td>
  </tr>
  <tr>
    <td>
      CB3011836
    </td>
    <td>
      Ketheleen Cristine Simão dos Santos
    </td>
  </tr>
  <tr>
    <td>
      CB3020282
    </td>
    <td>
      Ronald Pereira Evangelista
    </td>
  </tr>
</table>

## Exemplo de Uso

```csharp
using SWII6P2Verifications;

class Program
{
    static void Main(string[] args)
    {
        // Verificar se o produto está completo
        bool isProductValid = Verifications.IsProductFull("Produto Exemplo", 20.50);
        Console.WriteLine($"Produto válido: {isProductValid}");

        // Verificar se o usuário está completo
        bool isUserValid = Verifications.IsUserFull("Usuario Exemplo", "senha123");
        Console.WriteLine($"Usuário válido: {isUserValid}");
    }
}
