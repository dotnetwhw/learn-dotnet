pipeline {
    agent {
        image 'mcr.microsoft.com/dotnet/core/sdk'
        label '3.1'
    }
    stages {
        stage('build') {
            steps {
                sh 'dotnet build'
            }
        }
    }
}

