/* Style.css */
body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    background-color: #f4f4f4;
}

#editor {
    display: flex;
    flex-direction: column;
    height: 100vh;
    padding: 10px;
}

label {
    font-weight: bold;
    color: #007acc;
}

.code-section {
    margin-bottom: 20px;
}

#htmlCode,
#cssCode {
    background-color: #fff;
}

.code {
    width: 100%;
    height: 200px;
    padding: 10px;
    border: none;
    resize: none;
    font-family: "Courier New",
        monospace;
    border: 1px solid #ccc;
    border-radius: 5px;
}

button {
    padding: 5px 10px;
    background-color: #007acc;
    color: #fff;
    border: none;
    cursor: pointer;
    margin-right: 10px;
}

#downloadButton {
    text-decoration: none;
    background-color: #007acc;
    color: #fff;
    padding: 5px 10px;
    margin-right: 10px;
}

iframe {
    width: 100%;
    height: calc(100% - 320px);
    border: none;
}

#htmlCode::placeholder,
#cssCode::placeholder,
#jsCode::placeholder {
    color: hsl(113, 100%, 49%);
}

/* Styles for responsive UI */
@media (max-width: 768px) {
    .code-section {
        width: 100%;
        margin: 10px 0;
    }
    .code {
        width: 100%;
    }
}
/* Style for scrollable output box */
#output {
    background-color: #f0f0f0;
    border: 1px solid #ccc;
    padding: 10px;
    overflow-y: auto; 
    max-height: 300px; 
}
